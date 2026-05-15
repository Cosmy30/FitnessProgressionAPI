using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.ExerciseLogs;
using FitnessProgressionAPI.Extensions;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class ExerciseLogService : IExerciseLogService
    {
        private readonly AppDbContext _context;
        private readonly IWorkoutService _workoutService;

        public ExerciseLogService(AppDbContext context, IWorkoutService workoutService)
        {
            _context = context;
            _workoutService = workoutService;
        }

        public async Task<ExerciseLogResponseDto?> GetByIdAsync(int id)
        {
            var workoutIdOrNull = await _context.ExerciseLogs
                .Where(e => e.Id == id)
                .Select(e => (int?)e.WorkoutId)
                .FirstOrDefaultAsync();

            if (workoutIdOrNull == null)
            {
                return null;
            }

            var workoutId = workoutIdOrNull.Value;

            if (!await _workoutService.BelongsToCurrentUser(workoutId))
            {
                return null;
            }

            return await _context.ExerciseLogs
                .Where(e => e.Id == id)
                .Select(ExerciseLogMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<List<ExerciseLogResponseDto>?> GetExerciseLogsByWorkoutId(int workoutId)
        {
            if (!await _workoutService.BelongsToCurrentUser(workoutId))
            {
                return null;
            }

            return await _context.ExerciseLogs
                .Where(e => e.WorkoutId == workoutId)
                .Select(ExerciseLogMappings.ToDtoExpression())
                .ToListAsync();
        }

        public async Task<ExerciseLogResponseDto?> Create(int workoutId, CreateExerciseLogDto dto)
        {
            if (!await _workoutService.BelongsToCurrentUser(workoutId))
            {
                return null;
            }

            var exerciseLog = dto.ToExerciseLog(workoutId);
            _context.ExerciseLogs.Add(exerciseLog);
            await _context.SaveChangesAsync();

            return await _context.ExerciseLogs
                .Where(e => e.Id == exerciseLog.Id)
                .Select(ExerciseLogMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<ExerciseLogResponseDto?> Patch(int id, UpdateExerciseLogDto dto)
        {
            var exerciseLog = await _context.ExerciseLogs.FindAsync(id);

            if (exerciseLog == null || !await _workoutService.BelongsToCurrentUser(exerciseLog.WorkoutId))
            {
                return null;
            }

            exerciseLog.ApplyUpdate(dto);
            await _context.SaveChangesAsync();

            return await _context.ExerciseLogs
                .Where(e => e.Id == id)
                .Select(ExerciseLogMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var exerciseLog = await _context.ExerciseLogs.FindAsync(id);

            if (exerciseLog == null || !await _workoutService.BelongsToCurrentUser(exerciseLog.WorkoutId))
            {
                return false;
            }

            _context.ExerciseLogs.Remove(exerciseLog);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

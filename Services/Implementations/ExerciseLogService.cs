using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.ExerciseLogs;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class ExerciseLogService : IExerciseLogService
    {
        private readonly AppDbContext _context;
        private readonly IUserContext _userContext;

        public ExerciseLogService(AppDbContext context, IUserContext userContext)
        {
            _context = context;
            _userContext = userContext;
        }

        public Task<ExerciseLogResponseDto?> GetByIdAsync(int id)
        {
            return _context.ExerciseLogs
                .Where(e => e.Id == id)
                .Select(ExerciseLogMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<List<ExerciseLogResponseDto>?> GetExerciseLogsByWorkoutId(int workoutId)
        {
            int? dbUserId = await _context.Workouts
                .Where(w => w.Id == workoutId)
                .Select(w => (int?)w.UserId)
                .FirstOrDefaultAsync();

            if (dbUserId == null || dbUserId != _userContext.UserId)
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
            int? dbUserId = await _context.Workouts
                .Where(w => w.Id == workoutId)
                .Select(w => (int?)w.UserId)
                .FirstOrDefaultAsync();

            if (dbUserId == null || dbUserId != _userContext.UserId)
            {
                return null;
            }

            var exerciseLog = dto.ToExerciseLog(workoutId);
            _context.ExerciseLogs.Add(exerciseLog);
            await _context.SaveChangesAsync();

            return exerciseLog.ToDto();
        }
    }
}

using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Enums;
using FitnessProgressionAPI.Extensions;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class WorkoutService : IWorkoutService
    {
        private readonly AppDbContext _context;
        private readonly IUserContext _userContext;

        public WorkoutService(AppDbContext context, IUserContext userContext)
        {
            _context = context;
            _userContext = userContext;
        }

        public Task<WorkoutResponseDto?> GetById(int id)
        {
            return _context.Workouts
                .Where(w => w.Id == id)
                .Select(WorkoutMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<List<WorkoutResponseDto>> GetWorkoutsByUserId(int userId, WorkoutType? type)
        {
            var query = _context.Workouts
                .Where(w => w.UserId == userId);

            if (type != null)
            {
                query = query.Where(w => w.Type == type);
            }

            return await query
                .Select(WorkoutMappings.ToDtoExpression())
                .ToListAsync();
        }

        public async Task<WorkoutResponseDto?> Create(int userId, CreateWorkoutDto dto)
        {
            if (!Enum.IsDefined<WorkoutType>(dto.Type!.Value))
            {
                return null;
            }
            
            var workout = dto.ToWorkout(userId);
            _context.Workouts.Add(workout);
            await _context.SaveChangesAsync();

            return workout.ToDto();
        }

        public async Task<WorkoutResponseDto?> Patch(int id, UpdateWorkoutDto dto)
        {
            var workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return null;
            }

            if (dto.Type != null && !Enum.IsDefined<WorkoutType>(dto.Type.Value))
            {
                return null;
            }

            workout.ApplyUpdate(dto);
            await _context.SaveChangesAsync();

            return workout.ToDto();
        }

        public async Task<bool> Delete(int id)
        {
            var workout = await _context.Workouts.FindAsync(id);

            if (workout == null)
            {
                return false;
            }

            _context.Workouts.Remove(workout);
            await _context.SaveChangesAsync();

            return true;
        }

        public Task<bool> BelongsToCurrentUser(int workoutId)
        {
            return _context.Workouts.AnyAsync(w => w.Id == workoutId && w.UserId == _userContext.UserId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Enums;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;
using FitnessProgressionAPI.Extensions;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class WorkoutService : IWorkoutService
    {
        private readonly AppDbContext _context;

        public WorkoutService(AppDbContext context)
        {
            _context = context;
        }

        public Task<WorkoutResponseDto?> GetById(int id)
        {
            return _context.Workouts
                .Where(w => w.Id == id)
                .Select(WorkoutMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }

        public async Task<List<WorkoutResponseDto>> GetWorkoutsByUserId(int userId)
        {
            var userExists = await _context.Users.AnyAsync(u => u.Id == userId);

            if (!userExists)
            {
                return null;
            }
            
            return await _context.Workouts
                .Where(w => w.UserId == userId)
                .Select(WorkoutMappings.ToDtoExpression())
                .ToListAsync();
        }

        public async Task<WorkoutResponseDto?> Create(int userId, CreateWorkoutDto dto)
        {
            if (!Enum.IsDefined<WorkoutType>(dto.Type!.Value))
            {
                return null;
            }

            var userExists = await _context.Users.AnyAsync(u => u.Id == userId);

            if (!userExists)
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
    }
}

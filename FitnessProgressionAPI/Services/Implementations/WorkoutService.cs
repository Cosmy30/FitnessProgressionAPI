using Microsoft.EntityFrameworkCore;
using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;

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
    }
}

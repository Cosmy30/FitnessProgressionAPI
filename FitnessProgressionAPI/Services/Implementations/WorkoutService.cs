using FitnessProgressionAPI.Data;
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
    }
}

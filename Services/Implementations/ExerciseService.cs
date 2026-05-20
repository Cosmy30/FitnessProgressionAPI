using FitnessProgressionAPI.Data;
using FitnessProgressionAPI.DTOs.Exercises;
using FitnessProgressionAPI.Mappings;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FitnessProgressionAPI.Services.Implementations
{
    public class ExerciseService : IExerciseService
    {
        private readonly AppDbContext _context;

        public ExerciseService(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<ExerciseResponseDto>> GetAllAsync()
        {
            return _context.Exercises
                .Select(ExerciseMappings.ToDtoExpression())
                .ToListAsync();
        }
    }
}

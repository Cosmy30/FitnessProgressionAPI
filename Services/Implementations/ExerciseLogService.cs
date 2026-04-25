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

        public ExerciseLogService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ExerciseLogResponseDto?> GetByIdAsync(int id)
        {
            return _context.ExerciseLogs
                .Where(e => e.Id == id)
                .Select(ExerciseLogMappings.ToDtoExpression())
                .FirstOrDefaultAsync();
        }
    }
}

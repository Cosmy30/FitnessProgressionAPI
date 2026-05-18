using FitnessProgressionAPI.DTOs.Exercises;
using FitnessProgressionAPI.Models;
using System.Linq.Expressions;

namespace FitnessProgressionAPI.Mappings
{
    public static class ExerciseMappings
    {
        public static Expression<Func<Exercise, ExerciseResponseDto>> ToDtoExpression()
        {
            return e => new ExerciseResponseDto
            {
                Id = e.Id,
                Name = e.Name,
                Category = e.Category,
                DifficultyLevel = e.DifficultyLevel,
                Family = e.Family
            };
        }
    }
}

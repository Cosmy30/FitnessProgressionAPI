using FitnessProgressionAPI.DTOs.ExerciseLogs;
using FitnessProgressionAPI.Models;
using System.Linq.Expressions;

namespace FitnessProgressionAPI.Mappings
{
    public static class ExerciseLogMappings
    {
        public static Expression<Func<ExerciseLog, ExerciseLogResponseDto>> ToDtoExpression()
        {
            return u => new ExerciseLogResponseDto
            {
                Id = u.Id,
                ExerciseId = u.ExerciseId,
                ExerciseName = u.Exercise.Name,
                Sets = u.Sets,
                Reps = u.Reps,
                Weight = u.Weight,
                RestSeconds = u.RestSeconds
            };
        }
    }
}

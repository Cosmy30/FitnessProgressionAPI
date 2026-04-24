using FitnessProgressionAPI.DTOs.ExerciseLogs;
using FitnessProgressionAPI.Models;
using System.Linq.Expressions;

namespace FitnessProgressionAPI.Mappings
{
    public static class ExerciseLogMappings
    {
        public static Expression<Func<ExerciseLog, ExerciseLogResponseDto>> ToDtoExpression()
        {
            return e => new ExerciseLogResponseDto
            {
                Id = e.Id,
                ExerciseId = e.ExerciseId,
                ExerciseName = e.Exercise.Name,
                Sets = e.Sets,
                Reps = e.Reps,
                Weight = e.Weight,
                RestSeconds = e.RestSeconds
            };
        }

        public static ExerciseLogResponseDto ToDto(this ExerciseLog exerciseLog)
        {
            return new ExerciseLogResponseDto
            {
                Id = exerciseLog.Id,
                ExerciseId = exerciseLog.ExerciseId,
                ExerciseName = exerciseLog.Exercise.Name,
                Sets = exerciseLog.Sets,
                Reps = exerciseLog.Reps,
                Weight = exerciseLog.Weight,
                RestSeconds = exerciseLog.RestSeconds
            };
        }
    }
}

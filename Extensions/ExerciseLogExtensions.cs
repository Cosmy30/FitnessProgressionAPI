using FitnessProgressionAPI.Models;
using FitnessProgressionAPI.DTOs.ExerciseLogs;

namespace FitnessProgressionAPI.Extensions
{
    public static class ExerciseLogExtensions
    {
        public static void ApplyUpdate(this ExerciseLog exerciseLog, UpdateExerciseLogDto dto)
        {
            exerciseLog.Sets = dto.Sets ?? exerciseLog.Sets;
            exerciseLog.Reps = dto.Reps ?? exerciseLog.Reps;
            exerciseLog.Weight = dto.Weight ?? exerciseLog.Weight;
            exerciseLog.RestSeconds = dto.RestSeconds ?? exerciseLog.RestSeconds;
        }
    }
}

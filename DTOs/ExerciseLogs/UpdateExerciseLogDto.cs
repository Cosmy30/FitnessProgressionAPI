using System.ComponentModel.DataAnnotations;

namespace FitnessProgressionAPI.DTOs.ExerciseLogs
{
    public class UpdateExerciseLogDto
    {
        [Range(1, 100)]
        public int? Sets { get; set; }

        [Range(1, 1000)]
        public int? Reps { get; set; }

        [Range(1, 1000)]
        public decimal? Weight { get; set; }

        [Range(1, 3600)]
        public int? RestSeconds { get; set; }
    }
}

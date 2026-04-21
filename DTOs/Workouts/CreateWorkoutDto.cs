using System.ComponentModel.DataAnnotations;
using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.DTOs.Workouts
{
    public class CreateWorkoutDto
    {
        [Range(1, 1440)]
        public int DurationMinutes { get; set; }

        [StringLength(1000)]
        public string? Notes { get; set; }

        [Required]
        public WorkoutType? Type { get; set; }
    }
}

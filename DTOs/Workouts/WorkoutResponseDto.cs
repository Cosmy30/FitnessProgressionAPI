using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.DTOs.Workouts
{
    public class WorkoutResponseDto
    {
        public int Id { get; set; }
        public DateTime WorkoutDate { get; set; }
        public int DurationMinutes { get; set; }
        public string? Notes { get; set; }
        public WorkoutType Type { get; set; }
    }
}

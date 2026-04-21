using FitnessProgressionAPI.Models;
using FitnessProgressionAPI.DTOs.Workouts;

namespace FitnessProgressionAPI.Extensions
{
    public static class WorkoutExtensions
    {
        public static void ApplyUpdate(this Workout workout, UpdateWorkoutDto dto)
        {
            workout.WorkoutDate = dto.WorkoutDate ?? workout.WorkoutDate;
            workout.DurationMinutes = dto.DurationMinutes ?? workout.DurationMinutes;
            workout.Notes = dto.Notes ?? workout.Notes;
            workout.Type = dto.Type ?? workout.Type;
        }
    }
}

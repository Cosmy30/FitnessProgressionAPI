using System.Linq.Expressions;
using FitnessProgressionAPI.Models;
using FitnessProgressionAPI.DTOs.Workouts;

namespace FitnessProgressionAPI.Mappings
{
    public static class WorkoutMappings
    {
        public static Expression<Func<Workout, WorkoutResponseDto>> ToDtoExpression()
        {
            return w => new WorkoutResponseDto
            {
                Id = w.Id,
                WorkoutDate = w.WorkoutDate,
                DurationMinutes = w.DurationMinutes,
                Notes = w.Notes,
                Type = w.Type
            };
        }

        public static WorkoutResponseDto ToDto(this Workout workout)
        {
            return new WorkoutResponseDto
            {
                Id = workout.Id,
                WorkoutDate = workout.WorkoutDate,
                DurationMinutes = workout.DurationMinutes,
                Notes = workout.Notes,
                Type = workout.Type
            };
        }

        public static Workout ToWorkout(this CreateWorkoutDto dto, int userId)
        {
            return new Workout
            {
                WorkoutDate = DateTime.UtcNow,
                DurationMinutes = dto.DurationMinutes,
                Notes = dto.Notes,
                Type = dto.Type!.Value,
                UserId = userId
            };
        }
    }
}

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
    }
}

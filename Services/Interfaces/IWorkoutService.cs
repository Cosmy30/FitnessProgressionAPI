using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IWorkoutService
    {
        public Task<WorkoutResponseDto?> GetByIdAsync(int id);
        public Task<List<WorkoutResponseDto>?> GetWorkoutsByUserIdAsync(int userId, WorkoutType? type);
        public Task<WorkoutResponseDto?> CreateAsync(int userId, CreateWorkoutDto dto);
        public Task<WorkoutResponseDto?> PatchAsync(int id, UpdateWorkoutDto dto);
        public Task<bool> DeleteAsync(int id);
        public Task<bool> BelongsToCurrentUserAsync(int workoutId);
    }
}

using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IWorkoutService
    {
        public Task<WorkoutResponseDto?> GetById(int id);
        public Task<List<WorkoutResponseDto>> GetWorkoutsByUserId(int userId, WorkoutType? type);
        public Task<WorkoutResponseDto?> Create(int userId, CreateWorkoutDto dto);
        public Task<WorkoutResponseDto?> Patch(int id, UpdateWorkoutDto dto);
        public Task<bool> Delete(int id);
    }
}

using FitnessProgressionAPI.DTOs.Workouts;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IWorkoutService
    {
        public Task<WorkoutResponseDto?> GetById(int id);
        public Task<List<WorkoutResponseDto>> GetWorkoutsByUserId(int userId);
        public Task<WorkoutResponseDto> Create(CreateWorkoutDto dto);
        public Task<WorkoutResponseDto?> Patch(int id, UpdateWorkoutDto dto);
        public Task<bool> DeleteById(int id);
    }
}

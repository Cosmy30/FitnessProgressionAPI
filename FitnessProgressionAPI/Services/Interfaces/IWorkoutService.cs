using FitnessProgressionAPI.DTOs.Workouts;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IWorkoutService
    {
        public Task<WorkoutResponseDto?> GetById(int id);
        public Task<WorkoutResponseDto> Create(CreateWorkoutDto dto);
        public Task<WorkoutResponseDto?> Patch(int id, UpdateWorkoutDto dto);
        public Task<bool> DeleteById(int id);
    }
}

using FitnessProgressionAPI.DTOs.Exercises;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IExerciseService
    {
        public Task<List<ExerciseResponseDto>> GetAllAsync();
        public Task<ExerciseResponseDto?> GetByIdAsync(int id);
    }
}

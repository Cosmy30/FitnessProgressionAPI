using FitnessProgressionAPI.DTOs.ExerciseLogs;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IExerciseLogService
    {
        public Task<ExerciseLogResponseDto?> GetByIdAsync(int id);
    }
}

using FitnessProgressionAPI.DTOs.ExerciseLogs;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IExerciseLogService
    {
        public Task<ExerciseLogResponseDto?> GetByIdAsync(int id);
        public Task<List<ExerciseLogResponseDto>?> GetExerciseLogsByWorkoutIdAsync(int workoutId);
        public Task<ExerciseLogResponseDto?> CreateAsync(int workoutId, CreateExerciseLogDto dto);
        public Task<ExerciseLogResponseDto?> PatchAsync(int id, UpdateExerciseLogDto dto);
        public Task<bool> DeleteAsync(int id);
    }
}

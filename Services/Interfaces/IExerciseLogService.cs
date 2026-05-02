using FitnessProgressionAPI.DTOs.ExerciseLogs;

namespace FitnessProgressionAPI.Services.Interfaces
{
    public interface IExerciseLogService
    {
        public Task<ExerciseLogResponseDto?> GetByIdAsync(int id);
        public Task<List<ExerciseLogResponseDto>?> GetExerciseLogsByWorkoutId(int workoutId);
        public Task<ExerciseLogResponseDto?> Create(int workoutId, CreateExerciseLogDto dto);
    }
}

using FitnessProgressionAPI.DTOs.ExerciseLogs;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessProgressionAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ExerciseLogsController : ControllerBase
    {
        private readonly IExerciseLogService _exerciseLogService;

        public ExerciseLogsController(IExerciseLogService exerciseLogService)
        {
            _exerciseLogService = exerciseLogService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ExerciseLogResponseDto>> GetExerciseLogById(int id)
        {
            var result = await _exerciseLogService.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("/api/workouts/{workoutId}/exercise-logs")]
        public async Task<ActionResult<List<ExerciseLogResponseDto>>> GetWorkoutExerciseLogs(int workoutId)
        {
            var result = await _exerciseLogService.GetExerciseLogsByWorkoutId(workoutId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("/api/workouts/{workoutId}/exercise-logs")]
        public async Task<ActionResult<ExerciseLogResponseDto>> CreateExerciseLog(int workoutId, CreateExerciseLogDto dto)
        {
            var result = await _exerciseLogService.Create(workoutId, dto);

            if (result == null)
            {
                return NotFound();
            }

            return CreatedAtAction(nameof(GetExerciseLogById), new { result.Id } , result);
        }
    }
}

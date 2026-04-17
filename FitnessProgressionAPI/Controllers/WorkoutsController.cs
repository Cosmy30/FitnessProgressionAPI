using Microsoft.AspNetCore.Mvc;
using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Services.Interfaces;

namespace FitnessProgressionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutsController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;
        
        public WorkoutsController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutResponseDto>> GetWorkoutById(int id)
        {
            var result = await _workoutService.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("/api/users/{userId}/workouts")]
        public async Task<ActionResult<List<WorkoutResponseDto>>> GetUserWorkouts(int userId)
        {
            var result = await _workoutService.GetWorkoutsByUserId(userId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("/api/users/{userId}/workouts")]
        public async Task<ActionResult<WorkoutResponseDto>> CreateUserWorkout(int userId, CreateWorkoutDto dto)
        {
            var result = await _workoutService.Create(userId, dto);

            if (result == null)
            {
                return BadRequest("UserId not found or invalid workout type.");
            }

            return CreatedAtAction(nameof(GetUserWorkouts), new { userId }, result);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<WorkoutResponseDto>> PatchWorkout(int id, UpdateWorkoutDto dto)
        {
            var result = await _workoutService.Patch(id, dto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkout(int id)
        {
            var result = await _workoutService.Delete(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

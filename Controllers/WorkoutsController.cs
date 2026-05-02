using Microsoft.AspNetCore.Mvc;
using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Services.Interfaces;
using FitnessProgressionAPI.Enums;

namespace FitnessProgressionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutsController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;
        private readonly IUserService _userService;
        
        public WorkoutsController(IWorkoutService workoutService, IUserService userService)
        {
            _workoutService = workoutService;
            _userService = userService;
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
        public async Task<ActionResult<List<WorkoutResponseDto>>> GetUserWorkouts(int userId, [FromQuery] WorkoutType? type)
        {
            if (!await _userService.UserExistsAsync(userId))
            {
                return NotFound();
            }
            
            var result = await _workoutService.GetWorkoutsByUserId(userId, type);

            return Ok(result);
        }

        [HttpPost("/api/users/{userId}/workouts")]
        public async Task<ActionResult<WorkoutResponseDto>> CreateUserWorkout(int userId, CreateWorkoutDto dto)
        {
            if (!await _userService.UserExistsAsync(userId))
            {
                return NotFound();
            }

            var result = await _workoutService.Create(userId, dto);

            if (result == null)
            {
                return BadRequest("The workout type must be a valid enum value.");
            }

            return CreatedAtAction(nameof(GetWorkoutById), new { id = result.Id }, result);
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

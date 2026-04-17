using Microsoft.AspNetCore.Mvc;
using FitnessProgressionAPI.DTOs.Users;
using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Services.Interfaces;

namespace FitnessProgressionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IWorkoutService _workoutService;

        public UsersController(IUserService userService, IWorkoutService workoutService)
        {
            _userService = userService;
            _workoutService = workoutService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserResponseDto>>> GetUsers()
        {
            var result = await _userService.GetAll();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponseDto>> GetUserById(int id)
        {
            var result = await _userService.GetById(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("{userId}/workouts")]
        public async Task<ActionResult<List<WorkoutResponseDto>>> GetUserWorkouts(int userId)
        {
            var result = await _workoutService.GetWorkoutsByUserId(userId);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<UserResponseDto>> CreateUser(CreateUserDto dto)
        {
            var result = await _userService.Create(dto);
            
            return CreatedAtAction(nameof(GetUserById), new { id = result.Id }, result);
        }

        [HttpPost("{userId}/workouts")]
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
        public async Task<ActionResult<UserResponseDto>> PatchUser(int id, UpdateUserDto dto)
        {
            var result = await _userService.Patch(id, dto);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userService.DeleteById(id);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}

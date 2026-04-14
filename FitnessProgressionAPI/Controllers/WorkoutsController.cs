using FitnessProgressionAPI.DTOs.Workouts;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    }
}

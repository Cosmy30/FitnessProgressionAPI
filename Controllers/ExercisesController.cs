using FitnessProgressionAPI.DTOs.Exercises;
using FitnessProgressionAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessProgressionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExercisesController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;

        public ExercisesController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ExerciseResponseDto>>> GetExercisesAsync()
        {
            var result = await _exerciseService.GetAllAsync();

            return Ok(result);
        }
    }
}

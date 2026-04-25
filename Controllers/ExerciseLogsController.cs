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
    }
}

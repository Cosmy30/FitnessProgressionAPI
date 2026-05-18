using Microsoft.AspNetCore.Mvc;
using FitnessProgressionAPI.Services.Interfaces;

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
    }
}

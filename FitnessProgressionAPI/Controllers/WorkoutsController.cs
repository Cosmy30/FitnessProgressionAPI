using Microsoft.AspNetCore.Mvc;
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
    }
}

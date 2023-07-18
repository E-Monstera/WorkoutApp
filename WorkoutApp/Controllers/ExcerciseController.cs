using Microsoft.AspNetCore.Mvc;
using WorkoutApp.Models;
using WorkoutApp.Services;
using WorkoutApp.Services.Interfaces;

namespace WorkoutApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcerciseController : ControllerBase
    {
      

        private readonly ILogger<ExcerciseController> _logger;
        private IExcerciseService _excerciseService;
        public ExcerciseController(IExcerciseService excerciseService, ILogger<ExcerciseController> logger)
        {
            _excerciseService= excerciseService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Excercise>>> GetAll()
        {
            return Ok(await _excerciseService.GetAllNonCustomExcercises());
        }
    }
}
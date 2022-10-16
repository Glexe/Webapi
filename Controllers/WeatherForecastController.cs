using Microsoft.AspNetCore.Mvc;
using Webapi.Contexts;
using Webapi.Models;

namespace Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _dbContext = applicationDbContext;
        }

        [HttpGet(Name = "Test")]
        public ActionResult<User> Get()
        {
            return Ok(_dbContext.Users.FirstOrDefault());
        }
    }
}
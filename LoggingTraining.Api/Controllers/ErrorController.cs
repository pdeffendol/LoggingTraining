using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LoggingTraining.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ErrorController : ControllerBase
    {
        public ErrorController()
        {
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            throw new Exception("Manually generated exception");
        }
    }
}

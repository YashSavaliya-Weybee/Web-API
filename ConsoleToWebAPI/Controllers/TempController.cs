using ConsoleToWebAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return Ok("Hello");
        }

        [HttpGet("id")]
        public IActionResult CountryDetails([ModelBinder(Name = "CountryModel")] CountryModel country)
        {
            return Ok(country);
        }
    }
}

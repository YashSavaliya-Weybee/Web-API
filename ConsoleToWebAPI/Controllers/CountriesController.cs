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
    //[BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        //public CountryModel Country { get; set; }

        //public string Name { get; set; }
        //public int Population { get; set; }
        //public string Area { get; set; }

        [HttpPost("{id}")]
        public IActionResult addCountry([FromQuery] int id, [FromForm] CountryModel model)
        {
            return Ok($"Id = {id}, Name = {model.Name}, Population = {model.Population}, area = {model.Area}");
        }

    }
}

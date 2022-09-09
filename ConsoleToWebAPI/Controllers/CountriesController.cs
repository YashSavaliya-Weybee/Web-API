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

        [HttpPost("{name}/{population}/{area}")]
        public IActionResult addCountry([FromRoute] CountryModel model)
        {
            return Ok($"Name = {model.Name}, Population = {model.Population}, Area = {model.Area}");
        }

    }
}

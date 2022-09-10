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

        //[HttpPost("{id}")]
        //public IActionResult addCountry([FromHeader] int id)
        //{
        //    return Ok($"Id = {id}");
        //}

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))] string[] countries)
        {
            return Ok(countries[0] + " " + countries[1] + " " + countries[2] + " " + countries[3]);
        }

        //[HttpGet("{id}")]
        //public IActionResult CountryDetails([ModelBinder(Name = "Id")] CountryModel country)
        //{
        //    return Ok(country);
        //}

        [HttpGet("{id}")]
        public IActionResult Country1Details([ModelBinder(typeof(CustomBinderCountryDetails), Name = "Id")] CountryModel country)
        {
            return Ok(country);
        }
    }
}

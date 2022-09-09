﻿using ConsoleToWebAPI.Model;
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
    //[BindProperties]
    //[BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        //public CountryModel Country { get; set; }

        //public string Name { get; set; }
        //public int Population { get; set; }
        //public string Area { get; set; }

        //[HttpPost("")]
        [HttpGet("{name}/{area}")]
        public IActionResult addCountry(string name, int area)
        {
            return Ok($"Name = {name}, Area = {area}");
        }
        [HttpPost("")]
        public IActionResult addCountry1(CountryModel country)
        {
            return Ok($"Name = {country.Name}");
        }
    }
}

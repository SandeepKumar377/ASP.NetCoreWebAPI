using ASP.NetCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties] 
    public class CountriesController : ControllerBase
    { 
        public CountryModel Country { get; set; }

        [HttpPost("")]
        //[HttpGet("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {this.Country.Name}, Population = {this.Country.Population}, Area = {this.Country.Area}");
        }
    }
}

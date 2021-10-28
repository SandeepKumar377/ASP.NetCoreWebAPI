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
    public class CountriesController : ControllerBase
    {
        public CountryModel Country { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry([FromQuery]int id, [FromQuery]CountryModel country)
        {
            return Ok($"Name = {country.Name}, Population = {country.Population}, Area = {country.Area}");
        }
    }
}

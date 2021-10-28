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


        //[FromRoute]and[FromForm] attribute Bind Route date ex-/api/countries/4
        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute]int id, [FromForm]CountryModel country)
        {
            return Ok($"Id = {id}, Name = {country.Name}, Population = {country.Population}, Area = {country.Area}");
        }
    }
}

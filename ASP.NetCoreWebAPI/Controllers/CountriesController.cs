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


        //[FromRoute]and[FromHeader] attribute Bind Route date ex-/api/countries/4
        [HttpPost("{id}")]
        public IActionResult AddCountry([FromRoute]int id, [FromHeader]string name, [FromHeader]int age)
        {
            return Ok($"Id = {id}, Name = {name}, Age = {age}");
        }

        //Custom Model Binder url ex-/api/countries/search?countries=india|china|US

        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))]string[] countries)
        {
            return Ok(countries);
        }
    }
}

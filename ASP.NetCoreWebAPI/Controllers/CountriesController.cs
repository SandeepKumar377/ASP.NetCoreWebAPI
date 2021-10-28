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
    //[BindProperties(SupportsGet = true)] 
    public class CountriesController : ControllerBase
    {
        public CountryModel Country { get; set; }

        [HttpGet("{name}")]
        public IActionResult AddCountry([FromQuery]string name)
        {
            return Ok($"Name = {name}");
        }
    }
}

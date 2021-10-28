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
    [BindProperties]    //BindProperties at controller level
    public class CountriesController : ControllerBase
    {
       //[BindProperty]           //For httpPost Method
       //[BindProperty(SupportsGet =true)]           //For httpGet Method
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        //public CountryModel Country { get; set; }

        //[HttpPost("")]
        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {this.Name}, Population = {this.Population}, Area = {this.Area}");
        }
    }
}

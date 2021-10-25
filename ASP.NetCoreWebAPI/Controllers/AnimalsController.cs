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
    public class AnimalsController : ControllerBase
    {
        [Route("", Name ="ALL")]
        public IActionResult GetAnimals()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id=1, Name="Dog"},
                new AnimalModel() {Id=2, Name="Tigar"}
            };
            return Ok(animals);
        }
        
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id=1, Name="Dog"},
                new AnimalModel() {Id=2, Name="Tigar"}
            };
            //return AcceptedAtAction("GetAnimals");  //Call route by Action Name
            return AcceptedAtRoute("All");  //Call route by Route Name
        }
    }
}

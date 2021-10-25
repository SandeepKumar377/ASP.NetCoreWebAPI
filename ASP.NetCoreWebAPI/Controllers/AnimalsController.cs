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
        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id=1, Name="Dog"},
                new AnimalModel() {Id=2, Name="Tigar"}
            };
        }

        [Route("", Name ="ALL")]
        public IActionResult GetAnimals()
        {
            return Ok(animals);
        }
        
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            //return AcceptedAtAction("GetAnimals");  //Call route by Action Name
            return AcceptedAtRoute("All");  //Call route by Route Name
        }
        
        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC")) // if route not contains ABC example - /api/animals/testAC or /api/animals/testABC
            { 
                return BadRequest();
            }
            return Ok(animals);
        }
        
        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id==0)
            { 
                return BadRequest();
            }
            return Ok(animals.FirstOrDefault(x=>x.Id==id));
        }
        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        { 
            animals.Add(animal);
            
            //return Created("~/api/animals/" + animal.Id, animal);
            return CreatedAtAction("GetAnimalsById", new { id=animal.Id}, animal);  //Get Proper Route of Action method
        }
    }
}

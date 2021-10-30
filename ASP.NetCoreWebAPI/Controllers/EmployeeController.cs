using ASP.NetCoreWebAPI.Models;
using ASP.NetCoreWebAPI.Repository;
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
    public class EmployeeController : ControllerBase
    {
        //return specific data

        //public EmployeeModel GetEmployees()
        //{
        //    return new EmployeeModel() { Id=1, Name="Empoluee1"};
        //}


        //return list 

        //public List<EmployeeModel> GetEmployees()

        //use List<EmployeeModel> or IEnumerable<EmployeeModel> and for async data IAsyncEnumerable<EmployeeModel>
        [Route("")]
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>() {
                new EmployeeModel(){
                    Id = 1,
                    Name = "Empoluee1"
                },
                new EmployeeModel(){
                    Id = 2,
                    Name = "Empoluee2"
                }
            };
        }

        [Route("{id}")]        
        public IActionResult GetEmployees(int Id)
        {
            if (Id==0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>() {
                new EmployeeModel(){ Id = 1, Name = "Empoluee1" },
                new EmployeeModel(){ Id = 2, Name = "Empoluee2" }}
            );
        }

        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }
            return new EmployeeModel() { Id = 1, Name = "Empoluee1" };
        }

        [HttpGet("name")]
        public IActionResult GetName([FromServices] IProductRepository _productRepository)
        {
            var name = _productRepository.GetName();
            return Ok(name);
        }
    }
}

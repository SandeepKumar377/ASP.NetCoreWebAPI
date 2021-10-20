using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWebAPI.Controllers
{
    
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        [Route("get-all")] 
        [Route("getall")]
        //[Route("[action]/[controller]")]     //Token Replacement Routing
        public string GetAll()
        {
            return "Hello from GetAll";
        } 
        
        [Route("api/get-all-authors")]
        //[Route("[action]/[controller]")]     //Token Replacement Routing
        public string GetAllAuthors()
        {
            return "Hello from GetAuthor";
        }

        [Route("book/{id}/author/{authorid}")]
        public string GetById(int id, int authorid)
        {
            return "Get By book Id and Author Id " +id + " "+ authorid;
        }
        
        [Route("Search")]
        public string SearchBooks(int id, int authorid, string name, int rating, int price)
        {
            return "Id - " +id + " AuthorID -  "+ authorid + " Name - " + name + " Price - " + price + " Rating - " + rating;
        }
    }
}

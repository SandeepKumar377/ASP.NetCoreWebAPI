using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWebAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]/[action]")]               //Set base route as a controller level
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]    //This route override base route
        [Route("~/get-all")]        //This route override base route
        [Route("~/getall")]         //This route override base route
        public string GetAll()
        {
            return "Hello from GetAll";
        } 
        
        //[Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Hello from GetAuthor";
        }

        //[Route("book/{id}/author/{authorid}")]
        [Route("{id}")]
        public string GetById(int id, int authorid)
        {
            return "Get By book Id and Author Id " +id + " "+ authorid;
        }
        
        //[Route("Search")]
        public string SearchBooks(int id, int authorid, string name, int rating, int price)
        {
            return "Id - " +id + " AuthorID -  "+ authorid + " Name - " + name + " Price - " + price + " Rating - " + rating;
        }
    }
}

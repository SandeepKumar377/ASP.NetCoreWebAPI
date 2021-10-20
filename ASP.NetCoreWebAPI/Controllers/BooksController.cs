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
    public class BooksController : ControllerBase
    {
        //Route Constraints for url validation 


        //[Route("{id:int:min(10):max(100)}")]    //This Constraints use for define integer with min and max value
        [Route("{id:range(5,9)}")]              //This Constraints use for range
        public string GetId(int id)
        {
            return "Hello Int : " + id;
        }

        //[Route("{id:minlength(5):maxlength(20)}")]      
        //[Route("{id:length(5)}")]        //This Constraints use for define exact string length
        //[Route("{id:length(5):alpha}")]        //This Constraints use for only alfanumeric
        public string GetString(string id)
        {
            return "Hello String : " + id;
        }
        
        [Route("{id:regex(a(b|c))}")]       //By this value except only ab or ac means a followed by only  b or c
        public string GetStringRegex(string id)
        {
            return "Hello String : " + id;
        }
       
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from Get!";
        }

        public string Get1()
        {
            return "Hello from Get1!";
        }

    }
}

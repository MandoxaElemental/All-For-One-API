using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_For_One_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld : ControllerBase
    {
        private readonly HelloWorldServices _helloWorldServices;
        public HelloWorld(HelloWorldServices helloWorldServices){
            _helloWorldServices = helloWorldServices;
        }
        [HttpPost]
        [Route("HelloWorld/{name}")]
        public List<string> YourName(string name){
            return _helloWorldServices.AddNameToList(name);
        }
    }
}
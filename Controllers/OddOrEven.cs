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
    public class OddOrEven : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEven(OddOrEvenServices oddOrEvenServices){
            _oddOrEvenServices = oddOrEvenServices;
        }
        [HttpPost]
        [Route("OddorEven/{num}")]
        public List<string> EvenOrOdd(string num){
        return _oddOrEvenServices.EvenOrOdd(num);
        }
    }
}
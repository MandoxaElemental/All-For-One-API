using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.Services
{
    public class HelloWorldServices
    {
        public List<string> result = new();
        bool validCheck = false;
        int convertedNum;
        public List<string> AddNameToList(string name){
            validCheck = int.TryParse(name, out convertedNum);
            if (validCheck == true){
                result.Add("ERROR: Please enter a Name, not a Number");
            }
            else{    
            result.Add("Hello, " + name + "! It is nice to meet you!");
            }
            return result;
        }
    }
}
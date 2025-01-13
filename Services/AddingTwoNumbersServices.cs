using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.Services
{
    public class AddingTwoNumbersServices
    {
        public List<string> numbers = new();
        bool validCheck1 = false;
        int convertedNum1;
        bool validCheck2 = false;
        int convertedNum2;
        public List<string> AddNumbers(string numberOne, string numberTwo){
            validCheck1 = int.TryParse(numberOne, out convertedNum1);
            validCheck2 = int.TryParse(numberTwo, out convertedNum2);
            if(validCheck1 == false || validCheck2 == false){
                numbers.Add("Please Enter a Valid Number");
                return numbers;
            }
            else{
            numbers.Add(numberOne + " Plus " + numberTwo + " is Euqal to: " + (convertedNum1+convertedNum2) + ". Noice!");
        return numbers;
            }
        }
    }
}
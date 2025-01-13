using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.Services
{
    public class AskingQuestionsServices
    {
        public List<string> result = new();
        bool validCheck = false;
        int convertedNum;
        bool validCheck2 = false;
        int convertedNum2;
        public List<string> FinalQuestion(string name, string time){
            validCheck = int.TryParse(name, out convertedNum);
            validCheck2 = int.TryParse(time, out convertedNum2);
            if(validCheck == true || validCheck2 == false)
            {
                result.Add("ERROR: Please enter a valid Name/Hour");
                return result;
            }
            else{
            if (convertedNum2 > 12 || convertedNum2 == 0){
                result.Add("ERROR: Please Enter a Valid Hour between 1-12");
            }
            else{
                result.Add($"Good Morning {name}! Today you have woken up around {time}:00");
            }
            }
            
            return result;
        }

    }
}
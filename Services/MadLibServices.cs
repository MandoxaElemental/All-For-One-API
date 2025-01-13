using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.Services
{
    public class MadLibServices
    {
         public List<string> madLibList = new();
        public List<string> AddToMadLibList(string name, string adjective, string name2, string time, string room, string item, string bodyPart, string jobPosition, string name3, string ingVerb, string emotion, string adjective2, string oceanCreature, string color, string number, string animal, string familyMember, string timeOfDay, string adjective3, string nationality, string item2, string drink, string number2, string item3, string city){
            madLibList.Add($"My name is Detective {name}, and I am currently investigating the {adjective} case of Captain {name2}. Yesterday, at {time} PM, the Captain was found dead in the {room} of their private mansion with a/an {item} stuck into their {bodyPart}. According to the {jobPosition}, {name3} McTavish was last seen {ingVerb} towards the room with a look of pure {emotion} on their face. When I brought {name3} in for questioning, they claimed that the Captain was acting very {adjective2} before they left, muttering something about a/an {oceanCreature} and the color {color}. I quickly put two and {number} together. So the {color} {oceanCreature} Gang was involved... Well, call me a/an {animal}'s {familyMember}, this {timeOfDay} couldn't get any more {adjective3}. Well, just got to make sure I got my essentials: A/An {nationality} {item2}, my flask of {drink}, and my trusty {number2} caliber {item3}. Look out {city}, Detective {name} is on the case!");
            return madLibList;
        }
    }
}
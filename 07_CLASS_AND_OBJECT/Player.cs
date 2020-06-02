using System;
using System.Collections.Generic;
using System.Text;

namespace _07_CLASS_AND_OBJECT
{
    public class Player
    {
        Int32 ID, years;
        string name;

        public void SetPlayer(Int32 pID, Int32 pYears, string pName)
        {
            this.ID = pID;
            this.years = pYears;
            this.name = pName;
        }

        public string GetPlayer()
        {
            return "The player has ID: " + ID + ", is " + years + " old" + " and his name is: " + name; 
        }
    }
}

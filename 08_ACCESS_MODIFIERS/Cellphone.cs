using System;
using System.Collections.Generic;
using System.Text;

namespace _08_ACCESS_MODIFIERS
{
    class Cellphone
    {
        Int32 ID, Serial;
        string Brand;

        public Cellphone()
        {
            this.ID = 0;
            this.Serial = 01;
            this.Brand = "Default Brand";
        }

        public string GetCellphone()
        {
            return "Chellphone default information: " + "ID: " + ID + ", Serial: " + Serial + ", Brand: " + Brand; 
        }

    }
}

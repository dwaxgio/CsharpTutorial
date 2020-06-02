using System;
using System.Collections.Generic;
using System.Text;

namespace _07_CLASS_AND_OBJECT
{
    public class Videogame
    {
        Int32 ID;
        string Name;

        public void SetVideogame (int pID, string pName)
        {
            this.ID = pID;
            this.Name = pName;
        }

        public string GetVideogame()
        {
            return this.ID + " - " + this.Name;
        }
    }
}

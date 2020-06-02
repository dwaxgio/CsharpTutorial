using System;
using System.Collections.Generic;
using System.Text;

namespace _09_INHERITANCE_AND_POLYMORFISM
{
    public class Instruments
    {
        protected int ID;
        protected string Name, Type;

        public Instruments()
        {
            ID = 1;
            Name = "Guitarra";
            Type = "Acustica";
        }
        public void SetInstrument(int pID, string pName, string pType)
        {
            this.ID = pID;
            this.Name = pName;
            this.Type = pType;
        }

        public string GetInstrument()
        {
            return "Instrument: " + ID + ", - " + Name + ", - " + Type;
        }

        // Para polimorfismo: dos funciones con mismo nombre
        public void SetInstrument(string pName)
        {
            this.Name = pName;
        }
    }
}

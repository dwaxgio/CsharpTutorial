using System;
using System.Collections.Generic;
using System.Text;

namespace _10_ABSTRACT_CLASSES
{
    class Dog : Animal
    {
        protected Int32 ID;
        protected string Name;

        public void SetDog(Int32 pID, string pName)
        {
            this.ID = pID;
            this.Name = pName;
        }

        public string GetDog()
        {
            return Name;
        }
    }
}

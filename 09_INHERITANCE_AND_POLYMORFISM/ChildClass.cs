using System;
using System.Collections.Generic;
using System.Text;

namespace _09_INHERITANCE_AND_POLYMORFISM
{
    public class ChildClass : Instruments
    {
        public void ChangeAtributes(string ccType)
        {
            Type = ccType;
        }
    }
}

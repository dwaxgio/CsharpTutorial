using System;
using System.Collections.Generic;
using System.Text;

namespace _11_INTERFACE
{
    class Black : ColorInterface
    {
        protected int ID;
        protected string Name;

        public void SetColor(int pID, string pName)
        {
            this.ID = pID;
            this.Name = pName;
        }

        public string GetColor()
        {
            return Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_INTERFACE
{
    interface IConsolas
    {
        string nombre { get; set; }
        string fabricante { get; set; }

        void setConsola(string pNombre, string pFabricante);

        string getConsola();
    }
}

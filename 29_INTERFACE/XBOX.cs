using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_INTERFACE
{
    public class XBOX : IConsolas
    {
        public string nombre { get ; set; }
        public string fabricante { get; set ; }

        public string getConsola()
        {
            return this.nombre + " - " + this.fabricante;
        }

        public void setConsola(string pNombre, string pFabricante)
        {
            this.nombre = pNombre;
            this.fabricante = pFabricante;
        }
    }
}

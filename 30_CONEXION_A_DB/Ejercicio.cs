using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_CONEXION_A_DB
{
    public class Ejercicio
    {
        public int id;
        public string nombre;
        public int kilos;

        public Ejercicio(string pNombre, int pKilos)
        {
            this.nombre = pNombre;
            this.kilos = pKilos;
        }
    }
}

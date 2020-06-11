using System;
using System.Collections.Generic;
using System.Text;

namespace HR_19_INTERFACE
{
    // 2. Creo clase villano que hereda metodos de la Interfaz, y se les asigna un valor
    public class Villano : IPersonaje
    {
        public string poder = "rayo";

        public Villano()
        {

        }

        public void atacar()
        {
            Console.WriteLine("El villano ataca");
        }

        public void defender()
        {
            Console.WriteLine("El villano se cubre");
        }
    }
}

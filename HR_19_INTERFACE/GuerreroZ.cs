using System;
using System.Collections.Generic;
using System.Text;

namespace HR_19_INTERFACE
{
    // 2.2 Creo clase GuerreroZ que hereda metodos de la Interfaz, y se les asigna un valor
    public class GuerreroZ : IPersonaje
    {
        public string poder = "Kamehameha";

        public GuerreroZ()
        {

        }

        public void atacar()
        {
            Console.WriteLine("El GuerreroZ ataca");
        }

        public void defender()
        {
            Console.WriteLine("El GuerreroZ se defiende");
        }
    }
}

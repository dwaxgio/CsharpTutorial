using System;
using System.Runtime.Intrinsics.X86;
using static HR_20_1_POINTERS.Consolas;

namespace HR_20_1_POINTERS
{
    class Program
    {
        // Empleo de apuntadores
        Consolas miConsola = XBOX; // Solo puedo indicar valores contenidos en la clase Consolas

        public Program()
        {

        }

        static void Main(string[] args)
        {
            // Ejemplo de alias
            Program Halo = new Program();
            Program Halo2 = Halo; // Apuntan al mismo objeto en la memoria

            Halo2.miConsola = PC; 

            Console.WriteLine("Consola en la cual se juega Halo: " + Halo.miConsola);
            Console.WriteLine("Consola en la cual se juega Halo 2: " + Halo2.miConsola);
        }
    }
}

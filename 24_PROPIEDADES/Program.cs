using System;

namespace _24_PROPIEDADES
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon oLeon = new Leon();            
            Console.WriteLine(oLeon.Corre());
            Console.WriteLine(oLeon.Velocidad);

            Vuitre oVuitre = new Vuitre();
            Console.WriteLine(oVuitre.Volar());
        }
    }
}

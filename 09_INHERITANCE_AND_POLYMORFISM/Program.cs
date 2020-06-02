using _09_INHERITANCE_AND_POLYMORFISM;
using System;

namespace _09_INHERITANCE_AND_POLYMORPHISM
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clase hija
            ChildClass newChild = new ChildClass();

            Console.WriteLine(newChild.GetInstrument());

            newChild.ChangeAtributes("Electric");

            Console.WriteLine(newChild.GetInstrument());

            // Polimorfismo
            newChild.SetInstrument("Piano");
            Console.WriteLine(newChild.GetInstrument());

            Console.ReadKey();            
        }
    }
}

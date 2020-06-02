using System;

namespace _08_ACCESS_MODIFIERS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Los modificadores de acceso establecen la visibilidad de las propiedades o metodos de una clase

            // Private: Bloquea la clase o metodo, no se puede accesar desde una clase externa
            // Public: Se puede acceder a los miembros desde cualquier programa externo
            // Protected: Solo se puede acceder a los miembros, desde clases heredadas de la clase con dicho modificador de acceso

            // Constructor
            Cellphone defaultCellphone = new Cellphone();

            Console.WriteLine(defaultCellphone.GetCellphone());
            Console.ReadKey();
        }
    }
}

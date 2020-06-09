using System;
using System.Collections;

namespace _14_STACK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack (pila): LIFO: Last In, First Out, ej baraja de cartas
            // Declaracion de la pila
            //Stack st = new Stack();

            // Agregar elementos a la pila con push
            // Quitar elementos de la pila con pop
            // Contar elementos con Count
            // Verificar si contiene elementos con Cointains
            
            // Declaracion de la pila
            Stack miPila = new Stack();

            // Agregar elementos a la pila (LIFO)
            miPila.Push("Elemento 1");
            miPila.Push("Elemento 2");
            miPila.Push("Elemento 3");

            foreach (var item in miPila)
            {
                Console.WriteLine(item);
            }

            // Eliminar elemento de la pila
            
            miPila.Pop();
            Console.WriteLine("Luego de eliminar un elemento de la pila (el ultimo en entrar, es el primero en salir FIFO):");

            foreach (var item in miPila)
            {
                Console.WriteLine(item);
            }

            // Contar elementos de la pila
            Console.WriteLine("La pila contiene " + miPila.Count + " elementos.");

            // Contiene elemento especifico
            Console.WriteLine("La pila contiene el elemento 'Elemento 1'? :" + miPila.Contains("Elemento 1"));
        }
    }
}

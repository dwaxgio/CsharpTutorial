using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _15_QUEUE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cola Queue FIFO, ejemplo fila para entrar a un bus

            // Declaracion cola
            Queue miFila = new Queue();

            // Agregar elementos a la cola
            Console.WriteLine("Se agregan elementos a la cola con Enqueue: ");
            miFila.Enqueue("Elemento 1");
            miFila.Enqueue("Elemento 2");
            miFila.Enqueue("Elemento 3");

            foreach (var item in miFila)
            {
                Console.WriteLine(item);
            }

            // Eliminar elementos a la cola
            Console.WriteLine("Eliminar elementos a la cola con Dequeue:");
            miFila.Dequeue();

            foreach (var item in miFila)
            {
                Console.WriteLine(item);
            }

            // Contar elementos en la fila
            Console.WriteLine("La cola tiene " + miFila.Count + " elementos.");

            // Verificar si la cola contiene un elemento
            Console.WriteLine("La cola tiene el elemento 'Elemento 1'? " + miFila.Contains("Elemento 1"));

            // Stack<char> stack = new Stack<char>();
       

        }
    }
}

using System;

namespace _06_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipo de dato, llaves cuadradas para indicar que se va a almacenar una coleccion de datos del mismo t´po, nombre del array
            Int32[] values;

            values = new Int32[3];
            values[0] = 1; // Asigno el valor a un elemento del array (en un posicion del indice, en este caso 0)
            values[1] = 2;
            values[2] = 3;

            Console.WriteLine(values[0]);
            Console.WriteLine(values[1]);
            Console.WriteLine(values[2]);

            Console.ReadKey();
        }
    }
}

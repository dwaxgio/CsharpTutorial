using System;
using System.Collections;

namespace _13_ARRAY_LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList miArray = new ArrayList();
            miArray.Add(1);
            miArray.Add("Un valor");
            miArray.Add(true);

            Console.WriteLine("Valor de arraylist en posicion 0: " + miArray[0]);
            Console.WriteLine("Valor de arraylist en posicion 1: " + miArray[1]);
            Console.WriteLine("Valor de arraylist en posicion 2: " + miArray[2]);

            // count
            Console.WriteLine("Elementos en el array: " + miArray.Count);
            // Contains
            Console.WriteLine("El array contiene el valor 1: " + miArray.Contains(1));
            // remove at
            miArray.RemoveAt(0);
            Console.WriteLine("Si elimino el primer valor, quedan " + miArray.Count + " elementos");
        }
    }
}

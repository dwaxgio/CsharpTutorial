using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_METODO_ORDENAMIENTO_BURBUJA
{
    public class Program
    {
        static int[] numbers = new int[] { 10, 2, 3, 4, 5, 1, 9 };
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");
            Show();

            int contadorx = 0;
            int contadory = 0;
            // 1. Iteración de la lista
            for (int i = 0; i < numbers.Length; i++)
            {
                
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    
                    if(numbers[j] > numbers[j + 1])
                    {
                        int aux = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = aux;
                    }
                    contadory++;
                }
                contadorx++;
                Show();
            }
            Console.WriteLine("Iteraciones interno / externo: ");
            Console.WriteLine(contadorx);
            Console.WriteLine(contadory);

            Console.WriteLine("Luego de ordenamiento: ");
            Show();
            
            
            Console.ReadLine();
        }

        public static void Show() // Método para mostrar el array
        {
            foreach (var number in numbers)
            {
                Console.Write(number + ",");                
            }
            Console.WriteLine("\n");
        }
    }
}

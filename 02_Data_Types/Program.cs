using System;

namespace _02_DATA_TYPES
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro tipo de dato, nombre de variables y asigno valor
            Int32 num = 30;
            Console.WriteLine(num);

            // Double
            double num2 = 60.6;
            Console.WriteLine(num2);

            // Boolean
            Boolean status = true;
            if (status != true)
            {
                Console.WriteLine("The status is true: " + status);
            }
            else
            {
                Console.WriteLine("The status is false: " + status);
            }
            
            // String
            string message = "Hello";
            Console.WriteLine(message);
            
            Console.ReadKey();
        }
    }
}

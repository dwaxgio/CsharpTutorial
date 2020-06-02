using System;

namespace _04_VARIABLES_AND_OPERATORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "The value is: ";
            Int32 num = 66;

            Console.WriteLine(message + num);

            //
            Int32 num1 = 20, num2 = 30;
            bool status = true;

            Console.Write("The sum of the num1 and num2 is: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 < num2);
            Console.WriteLine(!(status));
            Console.ReadKey();
        }
    }
}

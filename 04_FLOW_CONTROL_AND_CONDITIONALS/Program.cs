using System;

namespace _05_FLOW_CONTROL_AND_CONDITIONALS
{
    class Program
    {
        static void Main(string[] args)
        {
            // if - conditional
            Int32 num = 11;

            if(num < 10)
            {
                Console.WriteLine("The number " + num + " is less than 10");
            }
            else
            {
                Console.WriteLine("The number " + num + " is greater than 10");
            }

            // if corto
            Console.WriteLine("If corto:");
            int num1 = 20;
            string validacion = (num > num1) ? $"{num} mayor a {num1}" : $"{num} menor a {num1}";
            Console.WriteLine(validacion);


            // Switch - conditional
            switch (num)
            {
                case 1: Console.WriteLine("Value is 1");
                    break;
                case 2: Console.WriteLine("Value is 2");
                    break;
                case 11: Console.WriteLine("Value is 11");
                    break;
                default:
                    break;
            }

            // While - loop
            Console.WriteLine("While loop");
            Int32 num2 = 3, j = 0;
            while (j<num2)
            {
                Console.WriteLine(j);
                j++;
            }

            // for - loop
            Console.WriteLine("For loop");
            for (Int32 i = 0; i<3; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

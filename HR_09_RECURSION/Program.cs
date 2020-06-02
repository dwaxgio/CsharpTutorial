using System;

namespace HR_09_RECURSION
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para recursividad, recordar ejemplo de muñeca matrioshka
            Console.Write("Please, enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factorial of !" + n + " is iqual to: " + Factorial(n));
            Console.WriteLine("The summation of " + n + " is iqual to: " + Summation(n));

            Console.Write("Please, enter a number for exponentiation: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The exponentiation of " + n + " with exponent ^" + p + " is equal to: " + Exponentiation(n, p));

            // Example with factorial
            static int Factorial(int pN)
            {
                // 3! = 3 * 2 * 1
                // 3! = 6
                if (pN <= 1)
                {
                    return 1;
                }
                else
                {
                    return pN * Factorial(pN - 1);
                }
            }

            static int Summation(int pN)
            {
                // Summation of 3 = 3+2+1+0
                if(pN <= 0)
                {
                    return 0;
                }
                else
                {
                    return pN + Summation(pN - 1);
                }

            }

            static int Exponentiation(int pN, int pE)
            {
                // Exponentiation of 3^3 = 3 * 3 * 3
                if (pE <= 0)
                {
                    return 1;
                }
                else
                {
                    return pN * Exponentiation(pN, pE - 1);
                }
            }

            Console.ReadKey();
        }
    }
}

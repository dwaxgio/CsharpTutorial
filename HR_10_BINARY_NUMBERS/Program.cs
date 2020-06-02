using System;

namespace HR_10_BINARY_NUMBERS
{
    class Program
    {
        /*
         * Objective
Today, we're working with binary numbers. Check out the Tutorial tab for learning materials and an instructional video!

Task
Given a base-10 integer,N , convert it to binary (base-2). Then find and print the base- 10 integer denoting the maximum number of consecutive 1's in N's binary representation.

Input Format

A single integer, .

Constraints

Output Format

Print a single base- integer denoting the maximum number of consecutive 's in the binary representation of .

Sample Input 1

5
Sample Output 1

1
Sample Input 2

13
Sample Output 2

2
Explanation

Sample Case 1:
The binary representation of  is , so the maximum number of consecutive 's is .

Sample Case 2:
The binary representation of  is , so the maximum number of consecutive 's is .
         */

        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int max = 0;

            while (n > 0)
            {
                if(n % 2 == 1)
                {
                    sum++;
                    if(sum > max)
                    {
                        max = sum;
                    }
                }
                else
                {
                    sum = 0;
                }
                n = n / 2;
            }
            Console.WriteLine(max);
        }
    }
}

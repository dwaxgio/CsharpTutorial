using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace HR_16_EXCEPTIONS_THROW
{
    class Program
    {
        public static readonly double tooHot = 185;
        public static readonly double tooCold = 160;

        public static void drinkHotChocolate(double cocoaTemp)
        {
            if (cocoaTemp >= tooHot)
            {
                throw new TooHotException();
            }
            else if (cocoaTemp <= tooCold)
            {
                throw new TooColdException();
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Please indicate the temperature of the chocolate...");
            //double currentCocoaTemp = Convert.ToDouble(Console.ReadLine());
            //try
            //{
            //    drinkHotChocolate(currentCocoaTemp);
            //    Console.WriteLine("That cocoa was good!");
            //}
            //catch (TooHotException e)
            //{
            //    Console.WriteLine("That cocoa was too hot, it burns my tongue...");
            //}
            //catch (TooColdException e)
            //{
            //    Console.WriteLine("That cocoa was too cold, its like the artic!");
            //}
            //Console.WriteLine("And its done.");

            Console.WriteLine("Please indicate the temperature of the chocolate...");
            double currentCocoaTemp = Convert.ToDouble(Console.ReadLine());
            Boolean wrongTemp = true;
            while (wrongTemp)
            {
                try
                {
                    drinkHotChocolate(currentCocoaTemp);
                    Console.WriteLine("That cocoa was good! " + currentCocoaTemp);
                    wrongTemp = false;
                }
                catch (TooHotException e)
                {
                    Console.WriteLine("That cocoa was too hot, it burns my tongue, its " + currentCocoaTemp);
                    currentCocoaTemp = currentCocoaTemp - 5;
                }
                catch (TooColdException e)
                {
                    Console.WriteLine("That cocoa was too cold, its like the artic! " + currentCocoaTemp);
                    currentCocoaTemp = currentCocoaTemp + 5;
                }
                //TimeSpan.FromSeconds(2);
                Thread.Sleep(2000); // espera 2 segundos
            }
            Console.WriteLine("And its done.");
        }
    }
}

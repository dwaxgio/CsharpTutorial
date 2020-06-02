using System;

namespace _03_ENUMERATION
{
    class Program
    {
        // Declaro el tipo de dato enum
        enum Days { sun, mon, tue, wed };
        static void Main(string[] args)
        {
            Console.WriteLine(Days.mon);
        }
    }
}

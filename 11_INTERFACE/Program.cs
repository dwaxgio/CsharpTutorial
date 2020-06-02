using System;

namespace _11_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            Black newBlack = new Black();
            newBlack.SetColor(1, "Negro");
            Console.WriteLine(newBlack.GetColor());
        }
    }
}

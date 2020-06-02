using System;

namespace _21_EXCEPTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try catch
            

            try
            {
                int x = 0;
                int y = 7 / x;
            }
            catch (Exception ex)
            {
                Console.WriteLine("El error es: " + ex.Message);
            }
        }
    }
}

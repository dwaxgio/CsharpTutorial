using System;

namespace HR_16_EXCEPTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice of how to handle exceptions
            try
            {
                //haga esto hasta que se obtenga una excepción
                int[] a = new int[5];
                Console.WriteLine("El elemento en la posición 6 del arreglo con tamaño 5 es:" + a[6]);
            }
            catch (Exception e)
            {
                // haga esto si se optiene la excepción
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Sin importar si se presenta error o no, en Finally se indica la salida que se desee
                Console.WriteLine("La aplicación terminó su ejecución, y ademas indicó la excepción presentada en el try-catch.");
            }
            // Console.WriteLine("La aplicación terminó su ejecución, y ademas indicó la excepción presentada en el try-catch.");
            Console.ReadKey();
        }
    }//
}

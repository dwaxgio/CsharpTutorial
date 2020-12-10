using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_TRY_CATCH
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    using (var archivo = new StreamWriter(@"C:\hola.txt"))
            //    {
            //        archivo.Write("prueba");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            int n1 = 9;
            int n2 = 0;

            try
            {
                int resultado = n1 / n2;

                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
            
        }
    }
}

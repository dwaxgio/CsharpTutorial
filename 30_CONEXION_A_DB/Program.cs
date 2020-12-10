using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_CONEXION_A_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            ConexionDB db = new ConexionDB();
            var ejercicios = db.Get();

            foreach (var item in ejercicios)
            {
                Console.WriteLine(item.nombre + " - " + item.kilos);
            }

            Console.ReadLine();
        }
    }
}

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

            // INSERT
            //Ejercicio PesoMuerto = new Ejercicio("Peso muerto", 120);
            //db.Add(PesoMuerto);

            // EDIT
            //Ejercicio PesoMuerto = new Ejercicio("Peso muerto", 180);
            //db.Edit(PesoMuerto, 3);

            // DELETE
            db.Delete(3);

            // SELECT
            var ejercicios = db.Get();

            foreach (var item in ejercicios)
            {
                Console.WriteLine(item.nombre + " - " + item.kilos);
            }

            Console.ReadLine();
        }
    }
}

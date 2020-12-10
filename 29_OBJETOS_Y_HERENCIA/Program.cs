using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OBJETOS_Y_HERENCIA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bebida oBebida = new Bebida("Cerveza", 1000);
            oBebida.Beber(300);

            Gaseosa oGaseosa = new Gaseosa();
            oGaseosa.SegundoSorbo(200);
             Console.ReadLine();
        }
    }
}

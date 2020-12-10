using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OBJETOS_Y_HERENCIA
{
    public class Gaseosa : Bebida
    {
        public Gaseosa() : base("Cocacola", 3000)
        {
            
        }

        public void SegundoSorbo(int pCantidadConsumida2)
        {
            this.cantidad -= pCantidadConsumida2;
            Console.WriteLine("Se ha consumido en total: " + cantidad);
        }
    }
}

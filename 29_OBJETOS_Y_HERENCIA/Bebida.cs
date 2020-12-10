using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OBJETOS_Y_HERENCIA
{
    public class Bebida
    {
        public string nombre;
        public int cantidad;

        public Bebida(string pNombre, int pCantidad)
        {
            this.nombre = pNombre;
            this.cantidad = pCantidad;
        }

        public void Beber(int pCantidadConsumida)
        {
            this.cantidad -= pCantidadConsumida;
            Console.WriteLine("Queda en la bebida: " + this.cantidad);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _25_POLIMORFISMO_DE_INCLUSION
{
    public class Mesero : Persona
    {
        // Acá ya se emplea el polimorfismo
        // En el siguiente constructor, recibo parametro pNombre, y se lo envio a la clase base Persona al parametro del constructor pNombre
        public Mesero(string pNombre) : base(pNombre) { }

        //Sobreescribo metodo Accion de clase heredada Persona
        public override void Accion()
        {
            Console.WriteLine(Nombre + " Atiende mesas");
        }
    }
}

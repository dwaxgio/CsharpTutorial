using System;
using System.Collections.Generic;
using System.Text;

namespace _25_POLIMORFISMO_DE_INCLUSION
{
    public class Cliente : Persona
    {
        // Acá ya se emplea el polimorfismo
        // En el siguiente constructor, recibo parametro pNombre, y se lo envio a la clase base Persona al parametro del constructor pNombre
        public Cliente(string pNombre) : base(pNombre) { }

        //Sobreescribo metodo Accion de clase heredada Persona
        public override void Accion()
        {
            Console.WriteLine(Nombre + " Se pone borracho");
        }
    }
}

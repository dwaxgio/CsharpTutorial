using System;
using System.Collections.Generic;
using System.Text;

namespace _25_POLIMORFISMO_DE_INCLUSION
{
    public class Persona
    {
        public string Nombre{ get; set; }

        public Persona(string pNombre)
        {
            this.Nombre = pNombre;
        }

        // Para sobrecargar método - sobreescritura
        public virtual void Accion() 
        {
            
        }
    }
}

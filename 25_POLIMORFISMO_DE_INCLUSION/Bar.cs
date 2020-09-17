using System;
using System.Collections.Generic;
using System.Text;

namespace _25_POLIMORFISMO_DE_INCLUSION
{
    public class Bar
    {
        List<Persona> lstPersonas = new List<Persona>();

        // Agrego metodo para agregar personas a la lista de personas, y activar su accion
        public void Entrar(Persona oPersona)
        {
            lstPersonas.Add(oPersona);
            // Se aplica polimorfismo de inclusión
            // Una vez que se agrega objeto, hace lo que tiene que hacer
            oPersona.Accion();
        }
    }
}

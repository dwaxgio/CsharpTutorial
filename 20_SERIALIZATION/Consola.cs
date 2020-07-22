using System;
using System.Collections.Generic;
using System.Text;

namespace _20_SERIALIZATION
{
    // 1. Definir clase a serializar
    [Serializable] // Atributo para serializar
    public class Consola
    {
        public int ID;
        public string Nombre;
    }
}

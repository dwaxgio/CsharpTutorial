using System;
using System.Collections.Generic;
using System.Text;

namespace _09_INHERITANCE_AND_POLYMORPHISM_2
{
    // 2. Se define clase hija
    public class UsuarioHeredado : Usuario // UsuarioHeredado hereda de clase Usuario
    {
        public void RenombrarUsuario(string pNombreNuevo) // Creo método propio de la clase hija, que modifica la información de la clase padre
        {
            // Ya puedo acceder a los atributos y metodos de la clase padre
            usuarioNombre = pNombreNuevo;
        }
    }
}

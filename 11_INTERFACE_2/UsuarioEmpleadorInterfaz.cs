using System;
using System.Collections.Generic;
using System.Text;

namespace _11_INTERFACE_2
{
    // 2. Establezco clase que implementa la interface
    public class UsuarioEmpleadorInterfaz : MiInterface
    {
        protected int ID;
        protected string usuarioNombre;

        public void setUsuario(int pID, string pNombre)
        {
            ID = pID;
            usuarioNombre = pNombre;
        }

        public string getUsuario()
        {
            return "Nombre Usuario: " + usuarioNombre;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _11_INTERFACE_2
{
    interface MiInterface
    {
        // 1. Establezco unicamente metodos de la interface, hasta la parte de los parametros, sin adentrarme en ellos
        void setUsuario(int pID, string pNombre);
        string getUsuario();        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HR_19_INTERFACE
{
    public interface IPersonaje
    {
        // 1. Creo interfaz con metodos predeterminados y que tienen que tener las clases herederas
        public void atacar();
        public void defender();
    }
}

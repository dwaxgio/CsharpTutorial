using System;
using System.Collections.Generic;
using System.Text;

namespace _24_PROPIEDADES
{
    public class Leon : Carnivoro
    {
        public string ColorCabello { get; set; }
        private int VelocidadDefecto = 20;
        public int Velocidad // Propiedad, puedo establecer operaciones tomando como base los atributos ya establecidos
        {
            get
            {
                return VelocidadDefecto * 100;
            }
            set
            {

            }
            
        }

        public string Corre() 
        {
            int VelMetros = Velocidad;
            return "El león correo en km : " + VelocidadDefecto + " y en mt: " + VelMetros ;
        }


    }
}

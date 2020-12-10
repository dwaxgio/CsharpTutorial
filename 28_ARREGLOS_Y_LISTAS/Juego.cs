using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ARREGLOS_Y_LISTAS
{
    public class Juego
    {
        public string nombre;
        public int jugadores;

        public Juego(string pNombre, int pJugadores)
        {
            this.nombre = pNombre;
            this.jugadores = pJugadores;
        }

        public void setJuego(string pNombre, int pJugadores)
        {
            this.nombre = pNombre;
            this.jugadores = pJugadores;
        }

        public string getJuego()
        {
            return "El juego: " + this.nombre + " tiene # jugadores: " + this.jugadores;
            //return this.nombre + this.jugadores;
        }
    }
}

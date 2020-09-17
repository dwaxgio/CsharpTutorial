using System;

namespace _25_POLIMORFISMO_DE_INCLUSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Bar oBar = new Bar();
            Persona oMesero = new Mesero("NombreDelMesero");
            Persona oCantinero = new Cantinero("NombreDelCantinero");
            Persona oCliente = new Cliente("NombreDelCliente");

            oBar.Entrar(oMesero);
            oBar.Entrar(oCantinero);
            oBar.Entrar(oCliente);
        }
    }
}

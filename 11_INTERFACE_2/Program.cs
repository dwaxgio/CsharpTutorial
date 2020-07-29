using System;

namespace _11_INTERFACE_2
{
    class Program
    {
        // Interface: Usado junto clases para definir un contrato (acuerdo de lo que la clase proveera a la aplicación)
        // La interface declara las propiedades y los metodos, los cuales tienene por obligación que ser implementados por la clase (para definir que hacer con ellos)

        static void Main(string[] args)
        {
            // 3. Implemento metodos de la clase que implementa la interfaz
            UsuarioEmpleadorInterfaz nuevoUsuario = new UsuarioEmpleadorInterfaz();
            nuevoUsuario.setUsuario(1, "Administrador");
            Console.WriteLine(nuevoUsuario.getUsuario());

            Console.ReadKey();
        }
    }
}

using System;

namespace _09_INHERITANCE_AND_POLYMORPHISM_2
{
    class Program
    {
        // Herencia: Clase hija hereda de clase padre atributos y metodos, tambien puede modificar su comportamiento si lo requiere, o definir sus propios metodos
        static void Main(string[] args)
        {
            // 3. Implemento en el programa los metodos de la clase padre y la clase hija

            //// Metodo clase hija

            UsuarioHeredado nuevoUsuario = new UsuarioHeredado();
            nuevoUsuario.setUsuario(1, "Administrador");
            Console.WriteLine(nuevoUsuario.getUusario());

            nuevoUsuario.RenombrarUsuario("Consulta");
            Console.WriteLine(nuevoUsuario.getUusario());

            Console.ReadKey();
        }
    }
}

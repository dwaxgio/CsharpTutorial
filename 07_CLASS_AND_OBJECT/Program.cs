using System;

namespace _07_CLASS_AND_OBJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clase: Encapsulación de propiedades y metodos, usadas para representar una entidad en tiempo real

            Videogame newVideogame = new Videogame();
            newVideogame.SetVideogame(1, "Halo");

            Console.WriteLine("The videogame has the ID and Name: " +newVideogame.GetVideogame());

            Player newPlayer = new Player();
            newPlayer.SetPlayer(1, 28, "Edward");
            
            Console.WriteLine("And its played by: " + newPlayer.GetPlayer());

        }
    }
}

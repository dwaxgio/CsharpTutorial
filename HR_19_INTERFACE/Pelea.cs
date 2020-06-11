using System;

namespace HR_19_INTERFACE
{
    class Pelea
    {
        // 3. Creo clase para invocar aleatoriamente un villano o guerreroz
        public static IPersonaje invocarPersonaje()
        {
            Random rand = new Random();
            if (Math.Abs(rand.Next()) %2 == 0)
            {
                return new Villano();
            }
            else
            {
                return new GuerreroZ();
            }
        }
        static void Main(string[] args)
        {
            // 4. Instancio clases villano y guerrero z, asi como invocacion d enuevo personaje
            Villano Freezer = new Villano();
            GuerreroZ Goku = new GuerreroZ();
            Freezer.atacar();
            Goku.atacar();
            Freezer.defender();
            Goku.defender();
            Console.WriteLine("Poder de Villano: " + Freezer.poder);
            Console.WriteLine("Poder de GuerreroZ: " + Goku.poder);

            IPersonaje nuevoPersonaje = invocarPersonaje();
            nuevoPersonaje.atacar();
            nuevoPersonaje.defender();
        }
    }
}

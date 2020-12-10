using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_ARREGLOS_Y_LISTAS
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            // Arreglo
            int[] numeros = new int[10] {  1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }; 

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Iteración: " + i + " = " + numeros[i]);
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Lista
            Console.WriteLine("***************************************");
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            
            for(int i = 3; i < 10; i++)
            {
                myList.Add(i);
            }

            foreach (var element in myList)
            {
                Console.WriteLine(element);
            }

            myList.Remove(2);

            foreach (var element in myList)
            {
                Console.WriteLine(element);
            }

            //
            //Juego oJuego = new Juego();
            //oJuego.setJuego("Halo", 2);
            //Console.WriteLine(oJuego.getJuego());

            List<Juego> misJuegos = new List<Juego>();
            misJuegos.Add(new Juego ("ac", 1));
            misJuegos.Add(new Juego("nfs", 2));

            foreach (var item in misJuegos)
            {
                Console.WriteLine(item.nombre);
            }

            Console.ReadLine();
        }
    }
}

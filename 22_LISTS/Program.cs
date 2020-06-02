using System;
using System.Collections.Generic;

namespace _22_LISTS
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> animal = new List<string>();

            //animal.Add("Perro");
            //animal.Add("Gato");

            //foreach (var item in animal)
            //{
            //    Console.WriteLine(item);
            //}

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(2, "Perro"));
            animals.Add(new Animal(4, "Gato"));

            foreach (var item in animals)
            {
                Console.WriteLine($"Years: {item.edad}, Animal: {item.nombre}");

            }

         


        }
    }
}

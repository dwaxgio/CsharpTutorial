using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _20_SERIALIZATION
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Crear objeto de la clase
            Consola nuevaConsola = new Consola();
            nuevaConsola.ID = 1;
            nuevaConsola.Nombre = "Xbox";

            // 3. Crear el stream del archivo
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\CURSO_C#_3_GURU99\CsharpTutorial\20_SERIALIZATION\Archivo.txt", FileMode.Create, FileAccess.Write);

            // 4. Serializar el objeto
            formatter.Serialize(stream, nuevaConsola);
            stream.Close();

            // 5. Se crea archivo stream para deserializar
            stream = new FileStream(@"D:\CURSO_C#_3_GURU99\CsharpTutorial\20_SERIALIZATION\Archivo.txt", FileMode.Open, FileAccess.Read);

            // 6. Se deserializa el objeto
            Consola nuevaConsola2 = (Consola)formatter.Deserialize(stream);

            // 7. Se escribe la informaciòn en consola
            Console.WriteLine(nuevaConsola2.ID);
            Console.WriteLine(nuevaConsola2.Nombre);

            Console.ReadKey();

        }
    }
}

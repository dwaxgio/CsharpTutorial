using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_FILE_OPERATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"D:\CURSO_C#_3_GURU99\CsharpTutorial\19_FILE_OPERATIONS\Example.txt";
            String path = @"D:/CURSO_C#_3_GURU99/CsharpTutorial/19_FILE_OPERATIONS/Archivo.txt";

            // 1. Exists
            Console.WriteLine("\n1. Exists");
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }

            // 2. ReadAllLines
            Console.WriteLine("\n2. ReadAllLines");
            string[] lines; // String array

            lines = File.ReadAllLines(path);

                // Console.WriteLine(lines[0]);
                // Console.WriteLine(lines[1]);
            
            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }

            // 3. ReadAllText
            Console.WriteLine("\n4. ReadAllText");
            string lines2;

            lines2 = File.ReadAllText(path);

            Console.Write(lines2);

            // 4. Copy
            Console.WriteLine("\n4. Copy");

            string copypath = @"D:/CURSO_C#_3_GURU99/CsharpTutorial/19_FILE_OPERATIONS/Archivo_copiado.txt";
            File.Copy(path, copypath);

            // 5. Delete
            Console.WriteLine("\n5. Delete");

            String path2 = @"D:/CURSO_C#_3_GURU99/CsharpTutorial/19_FILE_OPERATIONS/Archivo2.txt";
            File.Delete(path2);

            

            Console.ReadKey();
        }
    }
}

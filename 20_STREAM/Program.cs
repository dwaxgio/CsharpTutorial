using System;
using System.IO;

namespace _20_STREAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:/CURSO_C#_3_GURU99/CsharpTutorial/19_FILE_OPERATIONS/Archivo.txt";

            // 1. StreamReader
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            // 2. Stream Writer
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("\nLinea 3 - escrita por sistema");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
    }
}

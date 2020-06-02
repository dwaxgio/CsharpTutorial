using System;
using System.Collections;

namespace _12_COLLECTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList newArraylist = new ArrayList();
            newArraylist.Add(1);
            newArraylist.Add("Example of content inside array index");
            newArraylist.Add(true);

            Console.WriteLine("Contenidos array: ");
            Console.WriteLine(newArraylist[0]);
            Console.WriteLine(newArraylist[1]);
            Console.WriteLine(newArraylist[2]);

            Console.WriteLine("Count: ");
            Console.WriteLine(newArraylist.Count);

            Console.WriteLine("Contains: ");
            Console.WriteLine(newArraylist.Contains(1));

            Console.WriteLine("Remove at: ");
            Console.WriteLine(newArraylist[2]);
            newArraylist.RemoveAt(2);
            Console.WriteLine(newArraylist[2]);

            Console.ReadKey();
        }
    }
}

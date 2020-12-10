using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        {
            XBOX xbox360 = new XBOX();
            xbox360.setConsola("Xbox 360", "Microsoft");
            Console.WriteLine(xbox360.getConsola());

            Console.ReadLine();

        }
    }
}

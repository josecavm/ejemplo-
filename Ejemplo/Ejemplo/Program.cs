using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
          //  System.Console.WriteLine("Hola");
            //System.Console.ReadKey();

            Fibonacci f = new Fibonacci();
            Console.WriteLine(f.Calcular(1));
            Console.WriteLine(f.Calcular(2));
            Console.WriteLine(f.Calcular(3));
            Console.ReadKey();

        }
    }
}

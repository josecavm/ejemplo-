using System;
using System.Collections;
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
            //System.Console.WriteLine("Hola");
            //System.Console.ReadKey();

            Fibonacci f = new Fibonacci();
           /* Console.WriteLine(f.Calcular(1));
            Console.WriteLine(f.Calcular(2));
            Console.WriteLine(f.Calcular(3));
            Console.WriteLine(f.Calcular(4));
            Console.WriteLine(f.Calcular(5));
            Console.WriteLine(f.Calcular(6));
            Console.WriteLine(f.Calcular(7));
            Console.WriteLine(f.Calcular(8)); 
            Console.WriteLine(f.Calcular(10));
            Console.ReadKey();*/



            ArrayList FibonacciListaPrin = new ArrayList();
            FibonacciListaPrin.Add(4);
            FibonacciListaPrin.Add(6);
            FibonacciListaPrin.Add(20);
            FibonacciListaPrin.Add(1);
            FibonacciListaPrin.Add(11);
            FibonacciListaPrin.Add(25);

            f.ImprimirFibonacci(f.arraySincronizaLista(FibonacciListaPrin));
           
        }
    }
}

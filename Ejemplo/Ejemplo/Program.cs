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
            ArrayList FibonacciListaPrin = new ArrayList();
            FibonacciListaPrin.Add(4);
            FibonacciListaPrin.Add(6);
            FibonacciListaPrin.Add(20);
            FibonacciListaPrin.Add(1);
            FibonacciListaPrin.Add(11);
            FibonacciListaPrin.Add(25);


            Fibonacci f = new Fibonacci();
            f.ImprimirFibonacci(f.ArrayFibonacciList(FibonacciListaPrin));

        }
    }
}

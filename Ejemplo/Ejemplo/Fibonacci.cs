using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Fibonacci
    {
        
       
        public int Calcular(int f)
        {



            if (f == 1)
            {
                return 1;
            }
            else if (f == 2)
            {
                return 1;
            }
            else
            {
                return Calcular(f - 1) + Calcular(f - 2);
            }

            return 0;
        }

        public ArrayList ArrayFibonacciList(IEnumerable FiboList1)
        {
            ArrayList fibonacciList = new ArrayList();
            foreach (int a in FiboList1) 
            fibonacciList.Add(Calcular(a));


            return fibonacciList;
        }

        public void ImprimirFibonacci(IEnumerable FiboPrint)
        {
            Console.WriteLine("Fibonacci");
            Console.WriteLine();
            foreach(int a in FiboPrint)
            Console.Write("   \n{0}", a);

            Console.ReadLine();

        }

       
    }

    }    

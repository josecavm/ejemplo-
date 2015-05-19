using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Fibonacci
    {
       
       public int Calcular( int f){
       
          
           if (f == 1 )
           {
               return 1 ;
           }
           else if (f==2 )
           {
               return 1;
           }
           else
           {
                return f - 1;

           }

           return 0;
       }
    }
}

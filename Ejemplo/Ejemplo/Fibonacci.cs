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
	           else if (f==3 && f==4)
	           {
	                return f - 1;

               }
               else
               {
                   return Calcular(f - 1) + Calcular(f - 2);
               }
	
	           return 0;
	       }


    }
}
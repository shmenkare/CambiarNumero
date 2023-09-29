using System;
using System.Collections.Generic;
using System.Text;

namespace CambiarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 8, d = 25;
            
            Console.WriteLine("El primer valor es {0}", a);
            Console.WriteLine("El segundo valor es {0}", b);
            Console.WriteLine("Aplicamos la funcion cambiar numero y:");          
            
            CambiarNum(a, b);
            
            Console.WriteLine("El primer valor es {0}", c);
            Console.WriteLine("El segundo valor es {0}", d);
            Console.WriteLine("Aplicamos la funcion cambiar numero por referencia y:"); 
            
            CambiarNumRef(ref c, ref d);
            
            Console.WriteLine("El primer valor ahora es {0}", c);
            Console.WriteLine("El segundo valor ahora es {0}",d);
            
            Console.ReadKey();

        }
        static void CambiarNum(int n, int m)
        {
            int temp = 0;
            temp = n;
            n = m;
            m = temp;
            Console.WriteLine("El primer valor ahora es {0}",n);
            Console.WriteLine("El segundo valor ahora es {0}",m);
        }
        static void CambiarNumRef(ref int n, ref int m)
        {
            int temp = 0;
            temp = n;
            n = m;
            m = temp;
            //return n;
            //return m;
        }
    }
}

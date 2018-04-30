using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimales
{
    class Program
    {
       
        enum numHexa
        {
            A = 0x1, B = 0x2
        }

        static void Main(string[] args)
        {

            Console.WriteLine("ingrese un valor");
            int n = Int32.Parse(Console.ReadLine());
            while (n != -1)
            {
                if ((n & (int)numHexa.A) == (int)numHexa.A)
                {
                    Console.WriteLine("El numero ingresado es A");
                }
                else
                {
                    if ((n & (int)numHexa.B) == (int)numHexa.B)
                    {
                        Console.WriteLine("El numero ingresado es B");
                    }
                    else if ((n | (int)numHexa.A) == (int)numHexa.A)
                    {
                        Console.WriteLine("El numero ingresado es A");
                    }
                    else if ((n | (int)numHexa.B) == (int)numHexa.B)
                    {
                        Console.WriteLine("El numero ingresado es B");
                    }
                    else if ((n & ((int)numHexa.A | (int)numHexa.B)) != 0)
                    {
                        Console.WriteLine("El numero ingresado no es 0");
                    }
                    else 
                    {
                        Console.WriteLine("El numero ingresado no es A ni B");
                    }
                }
                Console.WriteLine("ingrese un valor");
                n = Int32.Parse(Console.ReadLine());
            }
        }   
    }
}

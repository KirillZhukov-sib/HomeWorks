using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int c = 10;
            int[] a = new int[c];
            Random r = new Random();

            for (int i = 0; i < c; i++)
            {
                a[i] = r.Next(0,101);
                Console.Write("{0} ", a[i]);
            }

            //Console.WriteLine();


             /*
            foreach (int b in a)
            {
                if (b == 0)
                {
                    Console.Write("ноль есть");
                    break;
                }
                else
                {
                    Console.WriteLine("Нуля нет");
                    break ;
                }
            }
             */


            Console.ReadLine();

        }
    }
}

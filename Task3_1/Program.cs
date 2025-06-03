using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно 2 числа");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a1 > a2)
            {
                Console.WriteLine($"{a1}>{a2}");
            }
            else
            {
                if (a1 < a2)
                {
                    Console.WriteLine($"{a1}<{a2}");
                }
                else
                {
                    Console.WriteLine($"{a1}={a2}");
                }

                Console.WriteLine();
                Console.ReadKey();

            }
        }
    }
}

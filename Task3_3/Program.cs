using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите поочередно 4 числа");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());

            int m = a1;

            if (a2 > m) { m = a2; }
            if (a3 > m) { m = a3; }
            if (a4 > m) { m = a4; };


            Console.WriteLine($"Наибольшее число {m}");
            Console.ReadKey();



        }
    }
}

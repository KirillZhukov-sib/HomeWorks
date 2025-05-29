using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Taks2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте поочередно два числа");
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());

            (a, b)=(b,a);
            Console.WriteLine($"новые числа {a}, {b}");
        }
    }
}

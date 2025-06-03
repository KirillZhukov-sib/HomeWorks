using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно 3 числа");

            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());

            int m = a1 >= a2 && a1 <= a3 ? a1 : a2 >= a1 && a2 <= a3 ? a2 : a3 >= a1 && a3 <= a2 ? a3 : a3;
            Console.WriteLine(m);

        }
    }
}

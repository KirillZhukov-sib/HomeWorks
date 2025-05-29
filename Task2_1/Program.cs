using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите поочередно 3 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int d = a;
            a = c;
            c = b;
            b = d;

            Console.WriteLine("{0}{1}{2}", a, b, c);
            Console.WriteLine("нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}

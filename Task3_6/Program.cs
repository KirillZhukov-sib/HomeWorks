using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == 0 || a % 10 == 2 || a % 10 == 4 || a % 10 == 6 || a % 10 == 8)
            { Console.WriteLine("Четное"); }
            else { Console.WriteLine("Нечетное"); }
                

        }
    }
}

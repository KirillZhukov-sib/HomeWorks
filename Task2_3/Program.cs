using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("запишите длину в дюймах");
            double d = Convert.ToDouble(Console.ReadLine());


            int metr = (int)((d * 25.4) / 1000);
            int sntmtr = (int)((d * 25.4) / 10 % 100);
            double mm = Math.Round((d * 25.4) % 10, 10);



            Console.WriteLine("{0} м {1} см {2}мм", metr, sntmtr, mm);
            Console.ReadKey();
        }
    }
}

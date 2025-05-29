using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину трубы в метрах");

            double l = Convert.ToDouble(Console.ReadLine());

            double r = Math.Ceiling(l);
            
            Console.WriteLine("Длина после округления {0}", r);

        }
    }
}

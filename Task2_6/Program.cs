using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину трубы в метрах: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double r = Math.Round(n * 2) / 2;

            Console.WriteLine("Округленная длина: {0}", r);
        }
    }
}

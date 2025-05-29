using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("запишите угол в градусах минутах и секундах");
            double d = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine());


            double r =Math.Round( Math.PI / 180 * (s / 3600 + m / 60 + d), 2 );



            Console.WriteLine("величина угла {0}, рад", r);
            Console.ReadKey();
        }
    }
}

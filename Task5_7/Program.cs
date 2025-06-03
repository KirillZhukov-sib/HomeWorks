using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 100 && a > 9)
            {
                Console.WriteLine("Двузначное");
            }
            else
            {
                Console.WriteLine("Недвузначное");
            }
        }
    }
}

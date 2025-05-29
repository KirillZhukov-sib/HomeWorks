using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите четырехзначное число");
            int a = Convert.ToInt32(Console.ReadLine());

            int f = a / 1000 * 1000 + a % 10 * 100 + a / 10 % 10 * 10 + a / 100 % 10;

            Console.WriteLine("ваше число с замененными цифрами второй на четвертую {0}", f);
        }
    }
}

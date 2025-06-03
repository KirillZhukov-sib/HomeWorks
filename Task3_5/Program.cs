using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int a = Convert.ToInt32(Console.ReadLine());
            string ln = a % 10 == 0 ? "Да" : "Нет";
            Console.WriteLine(ln);
                      

        }
    }
}

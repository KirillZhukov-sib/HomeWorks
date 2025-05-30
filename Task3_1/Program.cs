using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int abs = 0;

            if (n > 0) { abs = n; }
            else { abs = -0; }
            Console.WriteLine(abs);
            Console.ReadKey();


        }
    }
}

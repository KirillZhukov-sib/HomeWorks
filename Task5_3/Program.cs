using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 30;
            const int m = 3;
            int[,] t = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                double s = 0;
                for (int j = 0; j < m; j++)
                {
                    t[i, j] = rnd.Next(0, 30);
                    s += t[i, j];
                    Console.Write("{0, 4}", t[i, j]);
                }
                Console.WriteLine("{0, 6:f2}", s/m);
            }
            Console.ReadKey();
        }
    }
}

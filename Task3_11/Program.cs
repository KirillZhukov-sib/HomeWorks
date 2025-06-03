using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Габариты участка ");
            Console.WriteLine("Введите ширину участка:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину участка:");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Габариты дома номер 1");
            Console.WriteLine("Введите ширину дома номер 1");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину дома номер 1");
            int h1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Габариты дома номер 2");
            Console.WriteLine("Введите ширину дома номер 2");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину дома номер 2");
            int h2 = Convert.ToInt32(Console.ReadLine());

            int s1 = b1 + b2;
            int s2 = b1 + h2;
            int s3 = h1 + b2;
            int s4 = h1 + h2;
            string f;

            if (s1 <= b && (h1 <= h || h2 <= h))
            { f = "Данные дома могут разместиться на участке"; }
            else
            {
                if (s2 <= b && (h1 <= h || b2 <= h))
                {
                    f = "Данные дома могут разместиться на участке";
                }
                else
                {
                    if (s4 <= b && (b1 <= h || b2 <= h))
                    {
                        f = "Данные дома могут разместиться на участке";
                    }
                    else
                    {
                        if (s3 <= b && (b1 <= h || b2 <= h))
                        {
                            f = "Данные дома могут разместиться на участке";
                        }
                        else
                        {
                            if (s2 <= h && (h1 <= b || b2 <= b))
                            {
                                f = "Данные дома могут разместиться на участке";
                            }
                            else
                            {
                                if (s1 <= h && (h1 <= b || h2 <= b))
                                {
                                    f = "Данные дома могут разместиться на участке";
                                }
                                else
                                {
                                    if (s4 <= h && (b1 <= b || b2 <= b)) { f = "Данные дома могут разместиться на участке"; }
                                    else
                                    {
                                        if (s3 <= h && (h1 <= b || h2 <= b)) { f = "Данные дома могут разместиться на участке"; }
                                        else { f = "Данные дома не могут разместиться на участке"; }


                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}

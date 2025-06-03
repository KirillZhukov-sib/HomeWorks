using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество домов");
            int a = Convert.ToInt32(Console.ReadLine());
            string h;

            switch (a % 100)
            {
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    h = "домов";
                    break;
                default:
                    switch (a % 10)
                    {
                        case 1:
                            h = "дом";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            h = "дома"; break;
                        default:
                            h = "домов";
                            break;

                    }
                    break;
            }
            Console.WriteLine($"Компания построила {a} {h}");

        }
    }
}


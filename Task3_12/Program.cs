using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число в промежутке от 100-999");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a <= 999)
            {
                int a1 = a / 100;
                int a2 = a % 100;
                int a3 = a % 10;

                string b1 = "тест";
                string b2 = "тест";
                string b3 = "тест";
                string c;

                switch (a1)
                {
                    case 1: { b1 = "сто"; break; }
                    case 2: { b1 = "двести"; break; }
                    case 3: { b1 = "триста"; break; }
                    case 4: { b1 = "четыресто"; break; }
                    case 5: { b1 = "пятьсот"; break; }
                    case 6: { b1 = "шестьсот"; break; }
                    case 7: { b1 = "семьсот"; break; }
                    case 8: { b1 = "восемьсот"; break; }
                    case 9: { b1 = "девятьсот"; break; }

                }
                switch (a2)
                {
                    case 00: { b2 = " "; break; }
                    case 10: { b2 = "десять"; break; }
                    case 11: { b2 = "одиннадцать"; break; }
                    case 12: { b2 = "двенадцать"; break; }
                    case 13: { b2 = "тринадцать"; break; }
                    case 14: { b2 = "четырнадцать"; break; }
                    case 15: { b2 = "пятнадцать"; break; }
                    case 16: { b2 = "шестнадцать"; break; }
                    case 17: { b2 = "семьнадцать"; break; }
                    case 18: { b2 = "восемьнадцать"; break; }
                    case 19: { b2 = "девятнадцать"; break; }
                    default:
                        {
                            switch (a2 / 10)
                            {
                                case 2: { b2 = "двадцать"; break; }
                                case 3: { b2 = "тридцать"; break; }
                                case 4: { b2 = "сорок"; break; }
                                case 5: { b2 = "пятьдесят"; break; }
                                case 6: { b2 = "шестьдесят"; break; }
                                case 7: { b2 = "семьдесят"; break; }
                                case 8: { b2 = "восемьдесят"; break; }
                                case 9: { b2 = "девяносто"; break; }
                            }; break;
                        }
                }
                if (a2 == 10 || a2 == 11 || a2 == 12 || a2 == 13 || a2 == 14 || a2 == 15 || a2 == 16 || a2 == 17 || a2 == 18 || a2 == 19)
                {
                    b3 = "";
                }
                else
                {
                    switch (a3)
                    {
                        case 0: { b3 = ""; break; }
                        case 1: { b3 = "один"; break; }
                        case 2: { b3 = "два"; break; }
                        case 3: { b3 = "три"; break; }
                        case 4: { b3 = "четыре"; break; }
                        case 5: { b3 = "пять"; break; }
                        case 6: { b3 = "шесть"; break; }
                        case 7: { b3 = "семь"; break; }
                        case 8: { b3 = "восемь"; break; }
                        case 9: { b3 = "девять"; break; }
                        default: { b3 = "ошибка в написании числа"; break; }
                    }

                }

                Console.WriteLine($"Ваше число {b1} {b2} {b3}");
            }
            else
            {
                Console.WriteLine("Введенное число не соответствует условиям задачи");
            }
        }
    }
}

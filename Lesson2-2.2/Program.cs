using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2._2
{
    class Program
    {
        static void CurrencySelection(string currency, double eur, double usd, double rub)
        {
            Converter converter = new Converter(usd, eur, rub);

            switch (currency)
            {
                case "1":
                    {
                        Console.Write("Во что вы хотите перевести гривну в 1-Евро, 2-доллар, 3-рубль : ");
                        string currency1 = Console.ReadLine();
                        Console.Write("Сколько гривен вы хотите перевести : ");
                        double money = double.Parse(Console.ReadLine());
                        switch (currency1)
                        {
                            case "1":
                                {
                                    Console.WriteLine($"{money} переводим по курсу {eur} в евро и получили {converter.Eur(money)}");
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine($"{money} переводим по курсу {usd} в доллорфх и получили {converter.Usd(money)}");
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine($"{money} переводим по курсу {rub} в рублях и получили {converter.Rub(money)}");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Такой валюты нет.");
                                    break;
                                }
                        }

                        break;
                    }
                case "2":
                    {
                        Console.Write("Что вы хотите перевести в гривну в 1-Евро, 2-доллар, 3-рубль : ");
                        string currency1 = Console.ReadLine();
                        Console.Write("Сколько денег вы хотите перевести : ");
                        double money = double.Parse(Console.ReadLine());
                        switch (currency1)
                        {
                            case "1":
                                {
                                    Console.WriteLine($"{money} переводим по курсу {eur} в евро и получили {converter.Uan(money, eur)}");
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine($"{money} переводим по курсу {usd} в евро и получили {converter.Uan(money, usd)}");
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine($"{money} переводим по курсу {rub} в евро и получили {converter.Uan(money, rub)}");
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого перевода нет.");
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите курс относительно гривны в : ");
            Console.Write("Долларах : ");
            double usd = double.Parse(Console.ReadLine());
            Console.Write("Евро : ");
            double eur = double.Parse(Console.ReadLine());
            Console.Write("Рублях : ");
            double rub = double.Parse(Console.ReadLine());

            Console.Write("Во что вы хотите конвертировать 1-из гривны, 2-в гривну : ");
            string currency = Console.ReadLine();

            CurrencySelection(currency, eur, usd, rub);

            Console.ReadKey();
        }
    }
}

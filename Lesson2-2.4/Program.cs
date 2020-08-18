using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int account = 333444555;
            string customer = "Фирма";
            string provider = "Поставщик";
            Invoice invoice = new Invoice(account, customer, provider);

            Console.Write("Введите количество товара : ");
            int quantity = int.Parse(Console.ReadLine());
            invoice.Quantity(quantity);

            Console.Write("Введите стоимость единицы товара : ");
            double one = double.Parse(Console.ReadLine());

            Console.WriteLine($"Стоимость товара без НДС {invoice.CostCalculationWithout(one)}, стоимость товара с НДС {invoice.CostCalculationWith(one)}");

            Console.ReadKey();
        }
    }
}

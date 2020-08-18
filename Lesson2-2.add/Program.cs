using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2.add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш логин : ");
            string login = Console.ReadLine();
            Console.Write("Введите ваше имя : ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию : ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите сегодняшнюю дату : ");
            string date = Console.ReadLine();

            User user = new User(login, name, surname, age, date);
            user.OutputOnDisplay();

            Console.ReadKey();
        }
    }
}

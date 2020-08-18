using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2.add
{
    class User
    {
        string _login;
        string _name;
        string _surname;
        int _age;
        readonly string _date;

        public User(string login, string name, string surname, int age, string date)
        {
            _login = login;
            _name = name;
            _surname = surname;
            _age = age;
            _date = date;
        }
        public void OutputOnDisplay()
        {
            Console.WriteLine($"Ваш логин : {_login}. Ваше имя : {_name}. Ваша фамилия : {_surname}. Ваш возраст : {_age}. Дата заполнения анкеты : {_date}.");
        }
    }
}

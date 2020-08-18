using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя сотрудника : ");
            string name = Console.ReadLine();
            Console.WriteLine("Фамилия сотрудника : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Зарплата сотрудника : ");
            int salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, surname);

            Console.WriteLine($"Сотрудник : {name} {surname} ");
            Console.WriteLine($"Зарплата сотрудника составяет {salary}, без учета налогов (оклад) {employee.CalculationOfEmployeeSalary(salary)}, налог составляет {employee.TaxCalculation(salary)}");

            Console.ReadKey();
        }
    }
}

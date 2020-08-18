using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2._3
{
    class Employee
    {
        string _name;
        string _surname;
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public double CalculationOfEmployeeSalary(int salary)
        {
            double _salary = salary + TaxCalculation(salary);
            return _salary;
        }
        public double TaxCalculation(int salary)
        {
            double tax = salary * 13 / (100 - 13);
            return tax;
        }
    }
}

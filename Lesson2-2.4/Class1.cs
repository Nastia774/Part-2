using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2._4
{
    class Invoice
    {
        readonly int _account;
        readonly string _customer;
        readonly string _provider;
        string _article;
        int _quantity;

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }
        public void Quantity(int quantity)
        {
        set:
            { _quantity = quantity; }
        }
        public double CostCalculationWith(double one)
        {
            double with = CostCalculationWithout(one) * 0.2 + CostCalculationWithout(one);
            return with;
        }
        public double CostCalculationWithout(double one)
        {
            double without = one * _quantity;
            return without;
        }


    }
}

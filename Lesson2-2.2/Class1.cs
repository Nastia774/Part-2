using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2._2
{
    class Converter
    {
        double _usd;
        double _eur;
        double _rub;
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }
        public double Usd(double money)
        {
            double newUsd = _usd * money;
            return newUsd;
        }
        public double Eur(double money)
        {
            double newEur = _eur * money;
            return newEur;
        }
        public double Rub(double money)
        {
            double newRub = _rub * money;
            return newRub;
        }
        public double Uan(double money, double curs)
        {
            double newUan = money / curs;
            return newUan;
        }
    }
}

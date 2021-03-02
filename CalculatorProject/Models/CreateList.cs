using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    public class CreateList : IListCalculator
    {
        public List<Calculation> Calculations = new List<Calculation>();

        public Calculation ListCalculator(double a, double b, Func<double, double, double> _operation)
        {
            //calls respective create method
            var _calculation = Calculation.Create(a, b, _operation);

            return _calculation;
            //calls add method
        }

        public void ListCalculator(Calculation _calculation)
        {
            throw new NotImplementedException();
        }
    }

}

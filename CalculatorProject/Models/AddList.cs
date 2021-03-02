using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    public class AddList : IListCalculator
    {
        public List<Calculation> Calculations = new List<Calculation>();

        public void ListCalculator(Calculation _calculation)
        {
            Calculations.Add(_calculation);
        }

        public Calculation ListCalculator(double a, double b, Func<double, double, double> _operation)
        {
            throw new NotImplementedException();
        }
    }

}

using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class AddList : IListCalculator
    {
        /*
        public string ListCalculator()
        {
            return "The result of the product A2.";
        }
        */

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

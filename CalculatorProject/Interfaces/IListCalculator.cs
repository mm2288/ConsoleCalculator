using System;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{
    public interface IListCalculator
    {
        Calculation ListCalculator(double a, double b, Func<double, double, double> _operation);

        void ListCalculator(Calculation _calculation);
    }

}

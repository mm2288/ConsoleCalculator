using System;
using System.Collections.Generic;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{
    public interface IBulkCalculator
    {
        Calculation BulkCalculator(List<double> listOfValues, Func<List<double>, double> operation);

        void BulkCalculator(Calculation _calculation);
    }

}

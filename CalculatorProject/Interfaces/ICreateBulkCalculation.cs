using System;
using System.Collections.Generic;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{
    public interface ICreateBulkCalculation
    {
        Calculation CreateBulkCalculation(List<double> listOfValues, Func<List<double>, double> operation);
    }
}

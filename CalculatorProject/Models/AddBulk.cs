using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class AddBulk : IBulkCalculator
    {
        public List<Calculation> Calculations = new List<Calculation>();

        public void BulkCalculator(Calculation _calculation)
        {
            Calculations.Add(_calculation);
        }

        public Calculation BulkCalculator(List<double> listOfValues, Func<List<double>, double> operation)
        {
            throw new NotImplementedException();
        }
    }

}

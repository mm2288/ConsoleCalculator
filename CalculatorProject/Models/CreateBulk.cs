using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    public class CreateBulk : IBulkCalculator
    {
        public List<Calculation> Calculations = new List<Calculation>();

        public Calculation BulkCalculator(List<double> listOfValues, Func<List<double>, double> operation)
        {
            //calls respective create method
            var _calculation = Calculation.Create(listOfValues, operation);

            return _calculation;
            //calls add method
        }

        public void BulkCalculator(Calculation _calculation)
        {
            throw new NotImplementedException();
        }
    }

}

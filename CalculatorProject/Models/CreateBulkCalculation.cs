using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.Models
{
    interface ICreateBulkCalculation
    {
        void CreateBulkCalculation();
    }

    interface IAddBulkCalculation
    {
        void AddBulkCalculation();
    }

    class BulkCalculation : ICreateBulkCalculation, IAddBulkCalculation 
    {
        public List<Calculation> Calculations = new List<Calculation>();

        public Calculation CreateBulkCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {
            //calls respective create method
            var _calculation = Calculation.Create(listOfValues, operation);

            return _calculation;
            //calls add method
        }

        public void AddBulkCalculation(Calculation _calculation)
        {
            Calculations.Add(_calculation);
        }
    }
}

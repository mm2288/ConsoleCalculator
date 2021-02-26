using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class CreateBulk : IBulkCalculator
    {
        /*
        public string BulkCalculator()
        {
            return "The result of the product B1.";
        }
        */

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        /*
        public string AnotherBulkCalculator(IListCalculator collaborator)
        {
            var result = collaborator.ListCalculator();

            return $"The result of the B1 collaborating with the ({result})";
        }
        */

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

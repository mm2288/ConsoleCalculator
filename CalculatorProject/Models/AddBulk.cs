using System;
using System.Collections.Generic;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class AddBulk : IBulkCalculator
    {
        /*
        public string BulkCalculator()
        {
            return "The result of the product B2.";
        }
        */

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        /*
         * public string AnotherBulkCalculator(IListCalculator collaborator)
        {
            var result = collaborator.ListCalculator();

            return $"The result of the B2 collaborating with the ({result})";
        }
        */

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

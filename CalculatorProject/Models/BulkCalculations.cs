using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;

namespace CalculatorProject.Models
{
    public class BulkCalculations
    {
        public BulkCalculations()
        {
            // store a list of values for bulk operations
            public List<double> ListOfValues { get; set; }
            //store a bulk operations function
            public Func<List<double>, double> BulkOperation { get; set; }

            //constructor for 2 param (list, and function)
            public BulkCalculations(List<double> listOfValues, Func<List<double>, double> calculation)
            {
                ListOfValues = listOfValues;

                //this stores the operation to be performed on A and B
                BulkOperation = calculation;
            }

            public double GetResult()
            {
                return BulkOperation(ListOfValues);
            }
        }   
    }
}

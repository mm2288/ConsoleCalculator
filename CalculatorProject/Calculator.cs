using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Interfaces;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {
        public List<Calculation> Calculations = new List<Calculation>();

        public Calculator() { }

        /*Strategy*/
        /*
        private IListCalculator _listCalculator;

        private IBulkCalculator _bulkCalculator;

        public Calculator(IListCalculator listCalculator, IBulkCalculator bulkCalculator)
        {
            _listCalculator = listCalculator;

            _bulkCalculator = bulkCalculator;
        }

        public void SetListCalculator(IListCalculator listCalculator)
        {
            _listCalculator = listCalculator;
        }

        public void SetBulkCalculator(IBulkCalculator bulkCalculator)
        {
            _bulkCalculator = bulkCalculator;
        }
        */
        /*end strategy*/

        public void Main()
        {













            //strategy
            /*
            var listCalculator = new Calculator();
            listCalculator.SetListCalculator(new CreateList());

            var bulkCalculator = new Calculator();
            bulkCalculator.SetBulkCalculator(new CreateBulk());
            */
            //end strategy

            // The client code can work with any concrete factory class.
            ClientMethod(new CreateLists());

            ClientMethod(new CreateBulks());
        }

        public void ClientMethod(ICalculations factory)
        {
            Calculation list = (Calculation)factory.CreateList();
            Calculation bulk = (Calculation)factory.CreateBulk();

            //var productA = factory.CreateList();
            //var productB = factory.CreateBulk();

            //Console.WriteLine(productB.BulkCalculator());
            //Console.WriteLine(productB.AnotherBulkCalculator(productA));
        }

        //old code
        /*
        public void CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            
            var _calculation = new Calculation(a, b, _operation);

            Calculations.Add(_calculation);

        }
        public void CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {

            var _calculation = new Calculation(listOfValues, operation);

            Calculations.Add(_calculation);

        }
        */

        /*
        public Calculation CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            //calls respective create method
            var _calculation = Calculation.Create(a, b, _operation);

            return _calculation;
            //calls add method
        }
        */

        /*
        public Calculation CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {
            //calls respective create method
            var _calculation = Calculation.Create(listOfValues, operation);

            return _calculation;
            //calls add method
        }
        */

        /*
        public void AddCalculation(Calculation _calculation)
        {
            Calculations.Add(_calculation);
        }
        */


        //make add, remove, and get last calculation
    }
}

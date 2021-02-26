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

        private IListCalculator _listCalculator;

        private IBulkCalculator _bulkCalculator;

        public Calculator(IListCalculator listCalculator, IBulkCalculator bulkCalculator)
        {
            this._listCalculator = listCalculator;

            this._bulkCalculator = bulkCalculator;
        }

        public void SetListCalculator(IListCalculator listCalculator)
        {
            this._listCalculator = listCalculator;
        }

        public void SetBulkCalculator(IBulkCalculator bulkCalculator)
        {
            this._bulkCalculator = bulkCalculator;
        }
        /*end strategy*/

        public void Main()
        {
            //strategy
            var listCalculator = new Calculator();
            listCalculator.SetListCalculator(new CreateList());

            var bulkCalculator = new Calculator();
            bulkCalculator.SetBulkCalculator(new CreateBulk());
            //end strategy

            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new CreateLists());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new CreateBulks());
        }

        public void ClientMethod(ICalculations factory)
        {
            var productA = factory.CreateList();
            var productB = factory.CreateBulk();

            //Console.WriteLine(productB.BulkCalculator());
            //Console.WriteLine(productB.AnotherBulkCalculator(productA));
        }

        /*
        public List<Calculation> Calculations = new List<Calculation>();

        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }

        public void BulkCalculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            ICreateBulkCalculation _bulkOperation = new BulkCalculation();

            _bulkOperation.CreateBulkCalculation(listOfValues, _operation);
        }

        public void ListCalculator(double a, double b, Func<double, double, double> _operation)
        {
            ICreateListCalculation _listCalculation = new ListCalculation();

            _listCalculation.CreateListCalculation(a, b, _operation);
        }

        public void Calculate(double a, double b, Func<double, double, double> op, Calculation _calculation)
        {
            ICreateListCalculation _listCalculation = new ListCalculation();

            _listCalculation.CreateListCalculation(a, b, op);

            IAddListCalculation _addCalculation = new ListCalculation();

            _addCalculation.AddCalculation(_calculation);
        }
        */


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

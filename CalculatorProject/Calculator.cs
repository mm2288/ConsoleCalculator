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

        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }

        public Calculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {
            ICreateBulkCalculation _bulkOperation = new BulkCalculation();

            _bulkOperation.CreateBulkCalculation(listOfValues, _operation);
        }

        public Calculator(double a, double b, Func<double, double, double> _operation)
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

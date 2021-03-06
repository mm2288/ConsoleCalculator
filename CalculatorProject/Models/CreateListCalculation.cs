﻿using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class ListCalculation : ICreateListCalculation, IAddListCalculation
    {
        public List<Calculation> Calculations = new List<Calculation>();
        
        public Calculation CreateListCalculation(double a, double b, Func<double, double, double> _operation)
        {
            //calls respective create method
            var _calculation = Calculation.Create(a, b, _operation);

            return _calculation;
            //calls add method
        }
        

        public void AddCalculation(Calculation _calculation)
        {
            Calculations.Add(_calculation);
        }
    }
}

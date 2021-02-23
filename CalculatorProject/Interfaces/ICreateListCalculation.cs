using System;
using System.Collections.Generic;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{

    public interface ICreateListCalculation
    {

        //void CreateListCalculation();
        //Calculation CreateListCalculation();
        //Calculator CreateListCalculation(T obj);
        Calculation CreateListCalculation(double a, double b, Func<double, double, double> _operation);

    }
}

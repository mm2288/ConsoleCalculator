using System;
using System.Collections.Generic;
using CalculatorProject.Models;

namespace CalculatorProject.Interfaces
{
    public interface IBulkCalculator
    {
        // Product B is able to do its own thing...
        //string BulkCalculator();

        // ...but it also can collaborate with the ProductA.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        //string AnotherBulkCalculator(IListCalculator collaborator);

        Calculation BulkCalculator(List<double> listOfValues, Func<List<double>, double> operation);

        void BulkCalculator(Calculation _calculation);
    }

}

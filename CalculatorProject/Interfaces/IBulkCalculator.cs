using System;
namespace CalculatorProject.Interfaces
{
    public interface IBulkCalculator
    {
        // Product B is able to do its own thing...
        string BulkCalculator();

        // ...but it also can collaborate with the ProductA.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string AnotherBulkCalculator(IListCalculator collaborator);
    }

}

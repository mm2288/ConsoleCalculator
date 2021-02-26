using System;
namespace CalculatorProject.Interfaces
{
    public interface ICalculations
    {
        IListCalculator CreateList();

        IBulkCalculator CreateBulk();
    }

}

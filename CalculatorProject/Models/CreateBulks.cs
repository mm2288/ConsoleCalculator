using System;
namespace CalculatorProject.Models
{
    class CreateBulks : ICalculations
    {
        public IListCalculator CreateList()
        {
            return new AddList();
        }

        public IBulkCalculator CreateBulk()
        {
            return new AddBulk();
        }
    }

}

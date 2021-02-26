using System;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    public class CreateLists : ICalculations
    {
        public IListCalculator CreateList()
        {
            return new CreateList();
        }

        public IBulkCalculator CreateBulk()
        {
            return new CreateBulk();
        }
    }

}

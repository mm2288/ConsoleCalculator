using System;
namespace CalculatorProject.Models
{
    class CreateBulk : IBulkCalculator
    {
        public string BulkCalculator()
        {
            return "The result of the product B1.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherBulkCalculator(IListCalculator collaborator)
        {
            var result = collaborator.ListCalculator();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }

}

using System;
namespace CalculatorProject.Models
{
    class AddBulk : IBulkCalculator
    {
        public string BulkCalculator()
        {
            return "The result of the product B2.";
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherBulkCalculator(IListCalculator collaborator)
        {
            var result = collaborator.ListCalculator();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }

}

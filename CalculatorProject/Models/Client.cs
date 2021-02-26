using System;
using CalculatorProject.Interfaces;

namespace CalculatorProject.Models
{
    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new CreateLists());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new CreateBulks());
        }

        public void ClientMethod(ICalculations factory)
        {
            var productA = factory.CreateList();
            var productB = factory.CreateBulk();

            //Console.WriteLine(productB.BulkCalculator());
            //Console.WriteLine(productB.AnotherBulkCalculator(productA));
        }
    }

}

using Calculator.Engine;
using Calculator.Engine.Results;
using System;

namespace Calculator
{
    public class Application
    {
        private readonly ICalculationProvider _calculationProvider;

        public Application(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public void Run(string[] args)
        {
            Console.Write("Enter delimited numbers to be added:  ");
            var input = Console.ReadLine();

            Console.WriteLine(_calculationProvider.Calculate(input, CalculationType.AddWithEquation));

        }
    }
}

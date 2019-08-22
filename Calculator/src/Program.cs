using Calculator.Engine;
using Calculator.Engine.Results;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter delimited numbers to be added:  ");
            var input = Console.ReadLine();

            var engine = new CalculationProvider();
            Console.WriteLine(engine.Calculate(input, new AddEquationResult()));

        }
    }
}

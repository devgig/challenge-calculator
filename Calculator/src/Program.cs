﻿using Calculator.Engine;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 comma delimited numbers to be added:  ");
            var input = Console.ReadLine();

            var engine = new CalculationProvider();
            Console.WriteLine(engine.Calculate(input));

        }
    }
}
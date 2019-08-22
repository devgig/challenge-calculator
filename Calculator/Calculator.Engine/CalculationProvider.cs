using Calculator.Engine.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Engine
{
    public class CalculationProvider
    {
        public string Calculate(string input, ICalculationResult calculation)
        {
            var parser = new InputParser();
            var numbers = parser.Parse(input);

            if (numbers.Length == 0) //TODO GTN: What to do if invalid delimter
                return 0.ToString();

            var negatives = new List<string>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var num = numbers[i].ToNumber();

                if (num < 0) //capture negatives to throw exception
                {
                    negatives.Add(num.ToString());
                    continue;
                }

                calculation.Add(num > 1000 ? 0 : num); // ignore > 1000
            }

            if (negatives.Any())
                throw new InvalidOperationException(string.Join(",", negatives));


            return calculation.Display();

        }
    }
}

using Calculator.Engine.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Engine
{
    public interface ICalculationProvider
    {
        string Calculate(string input, CalculationType calculation = CalculationType.Add);
    }
    public class CalculationProvider : ICalculationProvider
    {
        private readonly IInputParser _inputParser;
        private readonly Func<CalculationType, ICalculationStrategy> _calculationFactory;

        public CalculationProvider(IInputParser inputParser, Func<CalculationType, ICalculationStrategy> calculationFactory)
        {
            _inputParser = inputParser;
            _calculationFactory = calculationFactory;
        }
        public string Calculate(string input, CalculationType calculation = CalculationType.Add)
        {
            
            var numbers = _inputParser.Parse(input);

            if (numbers.Length == 0) //TODO GTN: What to do if invalid delimter
                return 0.ToString();

            var strategy = _calculationFactory(calculation);

            var negatives = new List<string>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var num = numbers[i].ToNumber();

                if (num < 0) //capture negatives to throw exception
                {
                    negatives.Add(num.ToString());
                    continue;
                }

                strategy.AddToCalculation(num > 1000 ? 0 : num); // ignore > 1000
            }

            if (negatives.Any())
                throw new InvalidOperationException(string.Join(",", negatives));


            return strategy.DisplayCalculation();

        }


      
    }
}

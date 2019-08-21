using System;

namespace Calculator.Engine
{
    public class CalculationProvider
    {
        public int Calculate(string input)
        {
            if (input == null)
                return 0;

            var numbers = input.Split(',');

            if (numbers.Length == 0) //TODO GTN: What to do if invalid delimter
                return 0;

            if (numbers.Length == 1) //Nothing to add so just return number
                return numbers[0].ToNumber();  

            var result = 0;
            for (var i = 0; i < numbers.Length; i++)  
                result += numbers[i].ToNumber();

            return result;

        }
    }
}

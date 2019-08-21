using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Engine
{
    public class CalculationProvider
    {
        public int Calculate(string input)
        {
            if (input == null)
                return 0;

            var numbers = input.Split( new[] { ",", @"\n" }, StringSplitOptions.None);

            if (numbers.Length == 0) //TODO GTN: What to do if invalid delimter
                return 0;
                      

            if (numbers.Length == 1) //Nothing to add so just return number
                return numbers[0].ToNumber();  

            var result = 0;
            var negatives = new List<string>();

            for (var i = 0; i < numbers.Length; i++)
            {
                var num = numbers[i].ToNumber();

                if (num > 1000) continue; // ignore > 1000

                if (num < 0) //capture negatives to throw exception
                {
                    negatives.Add(num.ToString());
                    continue;
                }
                
                result += num;
            }

            if (negatives.Any())
                throw new InvalidOperationException(string.Join(",", negatives));
                    

            return result;

        }
    }
}

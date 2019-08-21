﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator.Engine
{
    public class CalculationProvider
    {
        public int Calculate(string input)
        {
            if (input == null)
                return 0;

            var regEx = new Regex(@"^//."); //capture custom delimiter
            var match = regEx.Match(input);
            var delimiter = match.Success ? match.Value?.Last().ToString() : "";

            var delimList = new List<string>();
            if(delimiter == "[")
            {
                var itemRegEx = new Regex(@"[^\[\]]+");
                var groupRegEx = new Regex(@"\[[^\[\]]+\]");
                var groupMatch = groupRegEx.Matches(input);
                foreach (var item in groupMatch)
                {
                    var itemMatch = itemRegEx.Match(item.ToString());
                    if (itemMatch.Success)
                        delimList.Add(itemMatch.Value);

                }

            }
            else
            {
                delimList.Add(delimiter);
            }
            

            delimList.AddRange(new[] { ",", @"\n" });
            var numbers = input.Split(delimList.ToArray(), StringSplitOptions.None);

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

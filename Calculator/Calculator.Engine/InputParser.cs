using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator.Engine
{
    public interface IInputParser
    {
        string[] Parse(string input);
    }
    public class InputParser : IInputParser
    {
        public string[] Parse(string input)
        {
            if (input == null)
                return new[] { "0" };

            var regEx = new Regex(@"^//."); //capture custom delimiter
            var match = regEx.Match(input);
            var delimiter = match.Success ? match.Value?.Last().ToString() : "";

            var delimList = new List<string>();
            if (delimiter == "[")
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
            return input.Split(delimList.ToArray(), StringSplitOptions.None);
        }
    }
}

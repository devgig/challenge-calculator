using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine.Results
{
    public class AddEquationResult : ICalculationResult
    {
        private int _result;
        private List<string> _equition;

        public AddEquationResult()
        {
            _result = 0;
            _equition = new List<string>();
        }
        public void Add(int number)
        {
            _result += number;
            _equition.Add(number.ToString());

        }

        public string Display()
        {
            return $"{string.Join('+', _equition)} = {_result}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine.Results
{
    public class AddNumericResult : ICalculationResult
    {
        private int _result;

        public AddNumericResult()
        {
            _result = 0;
        }
        public void Add(int number)
        {
            _result += number;
        }

        public string Display()
        {
            return _result.ToString();
        }
    }
}

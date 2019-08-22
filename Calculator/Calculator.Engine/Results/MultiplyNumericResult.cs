using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine.Results
{
    public class MultiplyNumericResult : ICalculationResult
    {
        private int _result;

        public MultiplyNumericResult()
        {
            _result = 1;
        }
        public void Add(int number)
        {
            _result *= number;
        }

        public string Display()
        {
            return _result.ToString();
        }
    }
}

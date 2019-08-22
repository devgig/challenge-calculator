﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine.Results
{
    public class SubtractNumericResult : ICalculationResult
    {
        private int _result;

        public SubtractNumericResult()
        {
            _result = default;
        }
        public void Add(int number)
        {
            if (_result == default)
                _result = number;
            else
                _result -= number;
        }

        public string Display()
        {
            return _result.ToString();
        }
    }
}

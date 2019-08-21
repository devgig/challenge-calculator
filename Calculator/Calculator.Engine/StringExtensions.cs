using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine
{
    public static class StringExtensions
    {
        public static int ToNumber(this string value)
        {
            return int.TryParse(value, out int n) ? n : 0;
        }
    }
}

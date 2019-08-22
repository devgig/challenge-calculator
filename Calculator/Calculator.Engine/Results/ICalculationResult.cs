using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine.Results
{
    public interface ICalculationResult
    {
       void Add(int number);
        string Display();
      
    }
}

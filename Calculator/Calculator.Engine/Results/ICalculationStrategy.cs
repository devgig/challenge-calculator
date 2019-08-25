using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Engine.Results
{
    public interface ICalculationStrategy 
    {
        bool CanProcess(CalculationType calculation);
        void AddToCalculation(int number);
        string DisplayCalculation();

    }

}

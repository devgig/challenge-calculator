using System.Collections.Generic;

namespace Calculator.Engine.Results
{
    public class AddEquationResult :  ICalculationStrategy
    {
        private int _result;
        private List<string> _equition;

        public AddEquationResult()
        {
            _result = 0;
            _equition = new List<string>();
        }
        public void AddToCalculation(int number)
        {
            _result += number;
            _equition.Add(number.ToString());

        }

        public string DisplayCalculation()
        {
            return $"{string.Join('+', _equition)} = {_result}";
        }

        public bool CanProcess(CalculationType calculation)
        {
            return calculation == CalculationType.AddWithEquation;
        }
    }
}

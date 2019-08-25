namespace Calculator.Engine.Results
{
    public class DivideNumericResult : ICalculationStrategy
    {
        private int _result;

        public DivideNumericResult()
        {
            _result = default;
        }
        public void AddToCalculation(int number)
        {
            if (_result == default)
                _result = number;
            else
                _result /= number;
        }

        public bool CanProcess(CalculationType calculation)
        {
            return calculation == CalculationType.Divide;
        }

        public string DisplayCalculation()
        {
            return _result.ToString();
        }
    }
}

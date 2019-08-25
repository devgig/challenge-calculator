namespace Calculator.Engine.Results
{
    public class SubtractNumericResult : ICalculationStrategy
    {
        private int _result;

        public SubtractNumericResult()
        {
            _result = default;
        }
        public void AddToCalculation(int number)
        {
            if (_result == default)
                _result = number;
            else
                _result -= number;
        }

        public bool CanProcess(CalculationType calculation)
        {
            return calculation == CalculationType.Subtract;
        }

        public string DisplayCalculation()
        {
            return _result.ToString();
        }
    }
}

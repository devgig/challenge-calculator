namespace Calculator.Engine.Results
{
    public class AddNumericResult : ICalculationStrategy
    {
        private int _result;

        public AddNumericResult()
        {
            _result = 0;
        }
        public void AddToCalculation(int number)
        {
            _result += number;
        }

        public bool CanProcess(CalculationType calculation)
        {
            return calculation == CalculationType.Add;
        }

        public string DisplayCalculation()
        {
            return _result.ToString();
        }
    }
}

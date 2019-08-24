namespace Calculator.Engine.Results
{
    public class AddNumericResult : ICalculationStrategy
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

        public bool CanProcess(CalculationType calculation)
        {
            return calculation == CalculationType.Add;
        }

        public string Display()
        {
            return _result.ToString();
        }
    }
}

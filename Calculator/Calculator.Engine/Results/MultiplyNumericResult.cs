namespace Calculator.Engine.Results
{
    public class MultiplyNumericResult : ICalculationStrategy
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

        public bool CanProcess(CalculationType calculation)
        {
            return calculation == CalculationType.Multiply;
        }

        public string Display()
        {
            return _result.ToString();
        }
    }
}

using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit2Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit2Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }
        public Unit2Tests() { }

        [Fact]
        public void should_support_more_than_two_number()
        {
            Assert.Equal("15", _calculationProvider.Calculate("1,2,3,4,5", new AddNumericResult()));

        }
    }
}

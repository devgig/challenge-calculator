using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit5Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit5Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public Unit5Tests() { }

        [Fact]
        public void should_ignore_numbers_greater_than_1000()
        {
            Assert.Equal("8", _calculationProvider.Calculate("2,1001,6", new AddNumericResult()));

        }
    }
}

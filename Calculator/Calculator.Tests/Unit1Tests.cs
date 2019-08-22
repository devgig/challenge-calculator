using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit1Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit1Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }
        public Unit1Tests() { }

        [Fact]
        public void should_support_scenario_one()
        {
            Assert.Equal("21", _calculationProvider.Calculate("1,20", new AddNumericResult()));
        }

        [Fact]
        public void should_support_scenario_two()
        {
            Assert.Equal("5", _calculationProvider.Calculate("5,tytyt", new AddNumericResult()));
        }

        [Fact]
        public void should_return_zero_for_invalid_scenarios()
        {
            Assert.Equal("0", _calculationProvider.Calculate("tytyt", new AddNumericResult()));
        }

    }
}

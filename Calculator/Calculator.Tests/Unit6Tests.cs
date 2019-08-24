using Calculator.Engine;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit6Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit6Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public Unit6Tests() { }

        [Fact]
        public void should_support_custom_delimeters()
        {
            Assert.Equal("7", _calculationProvider.Calculate("//;\n2;5"));

        }

        [Fact]
        public void should_support_custom_delimeter_with_all_scenarios()
        {
            Assert.Equal("17", _calculationProvider.Calculate("//|\n2|5,10"));

        }
    }
}

using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit7Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit7Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public Unit7Tests() { }

        [Fact]
        public void should_support_custom_delimiter_of_any_length()
        {
            Assert.Equal("66", _calculationProvider.Calculate(@"//[***]\n11***22***33", new AddNumericResult()));

        }
    }
}

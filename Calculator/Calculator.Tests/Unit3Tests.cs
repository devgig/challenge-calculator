using Calculator.Engine;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit3Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit3Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public Unit3Tests() { }

        [Fact]
        public void should_support_new_line_as_alt_delimeter()
        {
            Assert.Equal("6", _calculationProvider.Calculate(@"1\n2,3"));

        }
    }
}

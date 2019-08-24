using Calculator.Engine;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit8Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit8Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public Unit8Tests() { }

        [Fact]
        public void should_be_able_to_handle_multiple_custom_delimeters()
        {
            Assert.Equal("110", _calculationProvider.Calculate(@"//[*][!!][rrr]\n11rrr22*33!!44"));

        }

    }
}

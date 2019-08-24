using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Stretch4Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Stretch4Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }
        public Stretch4Tests() { }


        [Fact]
        public void should_multiply_results()
        {

            Assert.Equal("32", _calculationProvider.Calculate(@"8,4,1", CalculationType.Multiply));
        }


        [Fact]
        public void should_subtract_results()
        {

            Assert.Equal("3", _calculationProvider.Calculate(@"8,4,1", CalculationType.Subtract));
        }

        [Fact]
        public void should_divide_results()
        {

            Assert.Equal("2", _calculationProvider.Calculate(@"8,4,1", CalculationType.Divide));
        }



    }
}

using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Stretch1Tests
    {

        private readonly ICalculationProvider _calculationProvider;

        public Stretch1Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }
        public Stretch1Tests() { }


        [Fact]
        public void should_return_equation()
        {
            
            Assert.Equal("2+4+0+0+6 = 12", _calculationProvider.Calculate(@"2,4,rrrr,1001,6", CalculationType.AddWithEquation));
        }
    }
}

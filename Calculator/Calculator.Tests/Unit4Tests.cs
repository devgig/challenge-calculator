using Calculator.Engine;
using System;
using Xunit;
using Xunit.Ioc.Autofac;

namespace Calculator.Tests
{
    [UseAutofacTestFramework]
    public class Unit4Tests
    {
        private readonly ICalculationProvider _calculationProvider;

        public Unit4Tests(ICalculationProvider calculationProvider)
        {
            _calculationProvider = calculationProvider;
        }

        public Unit4Tests() { }

        [Fact]
        public void should_throw_exception_on_negative_numbers()
        {
            Assert.Throws<InvalidOperationException>(() => _calculationProvider.Calculate("1,-2,3"));
        }

        [Fact]
        public void should_throw_exception_that_includes_the_negative_numbers()
        {
            try
            {
                _calculationProvider.Calculate("1,-2,3,-4,-2");

            }
            catch (InvalidOperationException i)
            {
                Assert.Equal("-2,-4,-2", i.Message);
            }
        }
    }
}

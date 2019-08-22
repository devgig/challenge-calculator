using Calculator.Engine;
using Calculator.Engine.Results;
using System;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void should_throw_exception_on_negative_numbers()
        {
            var engine = new CalculationProvider();
            Assert.Throws<InvalidOperationException>(() => engine.Calculate("1,-2,3", new AddNumericResult()));
        }

        [Fact]
        public void should_throw_exception_that_includes_the_negative_numbers()
        {
            var engine = new CalculationProvider();
            try
            {
                engine.Calculate("1,-2,3,-4,-2", new AddNumericResult());

            }
            catch (InvalidOperationException i)
            {
                Assert.Equal("-2,-4,-2", i.Message);
            }
        }
    }
}

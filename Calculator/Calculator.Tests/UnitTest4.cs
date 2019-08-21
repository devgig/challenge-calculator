using Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void should_throw_exception_on_negative_numbers()
        {
            var engine = new CalculationProvider();
            Assert.Throws<InvalidOperationException>(() => engine.Calculate("1,-2,3"));
        }

        [Fact]
        public void should_throw_exception_that_includes_the_negative_numbers()
        {
            var engine = new CalculationProvider();
            try
            {
                engine.Calculate("1,-2,3,-4");

            }
            catch (InvalidOperationException i)
            {
                Assert.Equal("-2,-4", i.Message);
            }
        }
    }
}

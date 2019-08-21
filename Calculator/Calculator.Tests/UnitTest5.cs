using Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest5
    {
        [Fact]
        public void should_ignore_numbers_greater_than_1000()
        {
            var engine = new CalculationProvider();
            Assert.Equal(8, engine.Calculate("2,1001,6"));

        }
    }
}

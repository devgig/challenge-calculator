using Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void should_support_more_than_two_number()
        {
            var engine = new CalculationProvider();
            Assert.Equal(15, engine.Calculate("1,2,3,4,5"));

        }
    }
}

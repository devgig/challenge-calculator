using Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest7
    {
        [Fact]
        public void should_support_custom_delimiter_of_any_length()
        {
            var engine = new CalculationProvider();
            Assert.Equal(66, engine.Calculate(@"//[***]\n11***22***33"));

        }
    }
}

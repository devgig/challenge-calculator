using Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void should_support_new_line_as_alt_delimeter()
        {
            var engine = new CalculationProvider();
            Assert.Equal(6, engine.Calculate(@"1\n2,3"));

        }
    }
}

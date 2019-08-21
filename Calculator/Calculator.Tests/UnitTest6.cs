using Calculator.Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest6
    {
        [Fact]
        public void should_support_custom_delimeters()
        {
            var engine = new CalculationProvider();
            Assert.Equal(7, engine.Calculate("//;\n2;5"));

        }

        [Fact]
        public void should_support_custom_delimeter_with_all_scenarios()
        {
            var engine = new CalculationProvider();
            Assert.Equal(17, engine.Calculate("//|\n2|5,10"));

        }
    }
}

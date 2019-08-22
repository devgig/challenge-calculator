using Calculator.Engine;
using Calculator.Engine.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculator.Tests
{
    public class StretchTest1
    {
        [Fact]
        public void should_return_equation()
        {
            var engine = new CalculationProvider();
            Assert.Equal("2+4+0+0+6 = 12", engine.Calculate(@"2,4,rrrr,1001,6", new AddEquationResult()));
        }
    }
}

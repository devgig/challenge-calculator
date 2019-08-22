using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void should_support_scenario_one()
        {
            var engine = new CalculationProvider();
            Assert.Equal("21", engine.Calculate("1,20", new AddNumericResult()));
        }

        [Fact]
        public void should_support_scenario_two()
        {
            var engine = new CalculationProvider();
            Assert.Equal("5", engine.Calculate("5,tytyt", new AddNumericResult()));
        }

        [Theory]
        [InlineData("1|20")]
        [InlineData("")]
        [InlineData("tytyt")]
        public void should_return_zero_for_invalid_scenarios(string input)
        {
            var engine = new CalculationProvider();
            Assert.Equal("0", engine.Calculate(input, new AddNumericResult()));
        }

    }
}

using Calculator.Engine;
using Calculator.Engine.Results;
using Xunit;

namespace Calculator.Tests
{
    public class UnitTest8
    {
        [Fact]
        public void should_be_able_to_handle_multiple_custom_delimeters()
        {
            var engine = new CalculationProvider();
            Assert.Equal("110", engine.Calculate(@"//[*][!!][rrr]\n11rrr22*33!!44", new AddNumericResult()));

        }

    }
}

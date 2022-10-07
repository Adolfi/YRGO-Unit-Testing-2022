using Explore.Core;

namespace Explore.Tests.Lab.TDD
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(5, 4, 9)]
        [InlineData(2, 6, 8)]
        public void Given_TwoValues_When_Add_Then_ExpectResult(int value1, int value2, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(value1, value2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

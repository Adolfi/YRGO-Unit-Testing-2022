using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore.Tests.Lab
{
    public class Lab4_Theory
    {
        [Theory]
        [InlineData(2, 6, 8)]
        //[InlineData(8, 5, 13)]
        //[InlineData(3, 9, 12)]
        public void Given_Values_When_Add_Then_ExpectResult(int x, int y, int expected)
        {
            // Arrange
            var calculator = new ExampleCalculator();

            // Act
            var actual = calculator.Add(x, y);

            // Assert
            actual.ShouldBe(expected);
        }
    }
}

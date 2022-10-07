using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore.Tests.Lab
{
    public class Lab4_Fact
    {
        [Fact]
        public void Given_TwoValues_When_Add_Then_ExpectResult()
        {
            // Arrange
            var calculator = new ExampleCalculator();

            // Act
            var actual = calculator.Add(6, 2);

            // Assert
            actual.ShouldBe(8);
        }
    }

    public class ExampleCalculator
    {
        public int Add(int x, int y)
        {
            return 8; // BUG!!
        }
    }
}

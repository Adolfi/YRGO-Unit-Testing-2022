using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore.Tests.Lab
{
    public class Lab4
    {
        [Theory]
        [InlineData("Hello World", "Hello Class")]
        [InlineData("Good morning World", "Good morning Class")]
        [InlineData("Wzup World", "Wzup Class")]
        public void Given_StringValues_When_ReplaceWorldWithClass_Then_ExpectHelloClassString(string value, string expected)
        {
            // Act
            var actual = value.Replace("World", "Class");

            // Assert
            actual.ShouldBe(expected);
        }
    }
}
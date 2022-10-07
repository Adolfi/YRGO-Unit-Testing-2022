using Shouldly;

namespace Explore.Tests.Lab
{
    public class Lab2
    {
        [Fact]
        public void Given_StringValue_When_ToUpper_Then_ExpectUpperString()
        {
            // Arrange
            var value = "Hello World!";

            // Act
            var actual = value.ToUpper();

            // Assert
            Assert.Equal("HELLO WORLD!", actual);
        }

        [Fact]
        public void Given_StringValue_When_ToLower_Then_ExpectLowerString()
        {
            // Arrange
            var value = "Hello World!";

            // Act
            var actual = value.ToLower();

            // Assert
            Assert.Equal("hello world!", actual);
        }

        [Fact]
        public void Given_StringValue_When_ReplaceWorldWithClass_Then_ExpectHelloClassString()
        {
            // Arrange
            var value = "Hello World!";

            // Act
            var actual = value.Replace("World", "Class");

            // Assert
            Assert.Equal("Hello Class!", actual);
        }
    }
}

using Shouldly;

namespace Explore.Tests.Lab
{
    public class Lab3
    {
        [Fact]
        public void Given_StringValue_When_ToUpper_Then_ExpectUpperString()
        {
            // Arrange
            var value = "Hello World!";

            // Act
            var actual = value.ToUpper();

            // Assert
            actual.ShouldBe("HELLO WORLD!");
        }

        [Fact]
        public void Given_StringValue_When_ToLower_Then_ExpectLowerString()
        {
            // Arrange
            var value = "Hello World!";

            // Act
            var actual = value.ToLower();

            // Assert
            actual.ShouldBe("hello world!");
        }

        [Fact]
        public void Given_StringValue_When_ReplaceWorldWithClass_Then_ExpectHelloClassString()
        {
            // Arrange
            var value = "Hello World!";

            // Act
            var actual = value.Replace("World", "Class");

            // Assert
            actual.ShouldBe("Hello Class!");
        }
    }
}

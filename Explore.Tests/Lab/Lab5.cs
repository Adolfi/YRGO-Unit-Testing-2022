using Explore.Core;

namespace Explore.Tests.Lab
{
    public class GreetingServiceTests
    {
        [Fact]
        public void Given_Name_When_GetGreeting_Then_ExpectGreetingMessage()
        {
            // Arrange
            var firstName = "Dennis";
            var lastName = "Adolfi";
            var service = new GreetingService();

            // Act
            var actual = service.GetGreeting(firstName, lastName);

            // Assert
            Assert.Equal("Welcome Dennis Adolfi!", actual);
        }

        [Theory]
        [InlineData("Dennis", "Adolfi", "Welcome Dennis Adolfi!")]
        [InlineData("Anna", "Svensson", "Welcome Anna Svensson!")]
        public void Given_Names_When_GetGreeting_Then_ExpectGreetingMessage(string firstName, string lastName, string expected)
        {
            // Arrange
            var service = new GreetingService();

            // Act
            var actual = service.GetGreeting(firstName, lastName);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

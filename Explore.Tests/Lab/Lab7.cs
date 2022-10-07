using Explore.Core;
using NSubstitute;

namespace Explore.Tests.Lab
{
    public class GreetingServiceTests2
    {
        [Fact]
        public void Given_User_When_GetGreeting_Then_ExpectGreetingMessage()
        {
            // Arrange
            var service = new GreetingService();
            var user = Substitute.For<IUser>();
            user.FirstName.Returns("Dennis");
            user.LastName.Returns("Adolfi");

            // Act
            var actual = service.GetGreeting(user);

            // Assert
            Assert.Equal("Welcome Dennis Adolfi!", actual);
        }

        [Theory]
        [InlineData("Dennis", "Adolfi", "Welcome Dennis Adolfi!")]
        [InlineData("Anna", "Svensson", "Welcome Anna Svensson!")]
        public void Given_Users_When_GetGreeting_Then_ExpectGreetingMessage(string firstName, string lastName, string expected)
        {
            // Arrange
            var service = new GreetingService();
            var user = Substitute.For<IUser>();
            user.FirstName.Returns(firstName);
            user.LastName.Returns(lastName);

            // Act
            var actual = service.GetGreeting(user);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

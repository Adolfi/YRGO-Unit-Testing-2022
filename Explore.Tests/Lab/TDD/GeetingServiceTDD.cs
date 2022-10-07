using Explore.Core;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explore.Tests.Lab.TDD
{
    public class GeetingServiceTDD
    {
        //[Theory]
        [InlineData("Dennis", "Lars", "Adolfi", "Welcome Dennis Lars Adolfi!")]
        [InlineData("Anna", "Malin", "Svensson", "Welcome Anna Malin Svensson!")]
        public void Given_Users_When_GetGreeting_Then_ExpectGreetingMessage(string firstName, string middleName, string lastName, string expected)
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

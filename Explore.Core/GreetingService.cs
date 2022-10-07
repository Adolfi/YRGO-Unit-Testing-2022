namespace Explore.Core
{
    public class GreetingService
    {
        public string GetGreeting(string firstName, string lastName) => $"Welcome {firstName} {lastName}!";

        public string GetGreeting(IUser user)
        {
            return $"Welcome {user.FirstName} {user.LastName}!";
        }
    }
}
using Practice.Moduls;
using Practice.Services;

namespace Practice;

internal class Program
{
    static void Main(string[] args)
    {
        User user1 = new User()
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30,
            Balance = 1000,
            BornCity = "New York"
        };

        User user2 = new User()
        {
            FirstName = "Jane",
            LastName = "Smith",
            Age = 25,
            Balance = 1500,
            BornCity = "Los Angeles"
        };

        User user3 = new User()
        {
            FirstName = "Alice",
            LastName = "Johnson",
            Age = 28,
            Balance = 2000,
            BornCity = "Chicago"
        };

        
        IUserService userService = new UserService();
        userService.CreateUser(user1);
        userService.CreateUser(user2);
        userService.CreateUser(user3);
        userService.GetAllUsers();


        var allUsers = userService.GetAllUsers();
        
        foreach (var user in allUsers)
        {
            Console.WriteLine($"Name: {user.FirstName} {user.LastName}, Age: {user.Age}, Balance: {user.Balance}, City: {user.BornCity}");
        }
    }
}

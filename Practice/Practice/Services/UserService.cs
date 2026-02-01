using Practice.Moduls;

namespace Practice.Services;

public class UserService : IUserService
{
    List<User> Users;
    public UserService()
    {
        Users = new List<User>();
    }

    public Guid CreateUser(User user)
    {
        user.UserId = Guid.NewGuid();
        Users.Add(user);
        return user.UserId;
    }

    public bool DeleteUser(Guid userId)
    {
        foreach(var user in Users)
        {
            if (user.UserId == userId)
            {
                Users.Remove(user);
                return true;
            }
        }
        return false;
    }

    public List<User> GetAllUsers()
    {
        return Users;
    }

    public User? GetUserById(Guid userId)
    {
        foreach(var user in Users)
        {
            if(user.UserId == userId)
            {
                return user;
            }
        }
        return null;
    }

    public bool UpdateUser(User updatingUser)
    {
        foreach(var user in Users)
        {
            if(user.UserId == user.UserId)
            {
                user.FirstName = updatingUser.FirstName;
                user.LastName = updatingUser.LastName;
                user.Age = updatingUser.Age;
                user.Balance = updatingUser.Balance;
                user.BornCity = updatingUser.BornCity;
                user.Grade = updatingUser.Grade;
            }
            return true;
        }
        return false;
    }
}
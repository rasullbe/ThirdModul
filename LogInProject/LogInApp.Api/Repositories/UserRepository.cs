using LogInApp.Api.Entities;

namespace LogInApp.Api.Repositories;

public class UserRepository : IUserRepository
{
    public List<User>? GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public void SaveAllUsers(List<User> users)
    {
        throw new NotImplementedException();
    }

    public bool? UserBlocked(Guid userId)
    {
        throw new NotImplementedException();
    }

    public bool UserExists(Guid userId)
    {
        throw new NotImplementedException();
    }
}

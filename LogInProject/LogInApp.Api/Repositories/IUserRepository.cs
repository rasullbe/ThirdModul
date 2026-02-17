using LogInApp.Api.Entities;

namespace LogInApp.Api.Repositories;

public interface IUserRepository
{
    public List<User>? GetAllUsers();
    public void SaveAllUsers(List<User> users);
    public bool? UserBlocked(Guid userId);
    public bool UserExists(Guid userId);
}
using Practice.Moduls;
namespace Practice.Services;

public interface IUserService
{
    public List<User> GetAllUsers();
    public User? GetUserById(Guid userId);
    public Guid CreateUser(User user);
    public bool DeleteUser(Guid userId);
    public bool UpdateUser(User user);
}
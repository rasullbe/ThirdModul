using LogInApp.Api.Dtos;

namespace LogInApp.Api.Services;

public interface IUserService
{
    public List<UserGetDto> GetAllUsers(string token);
    public bool DeleteUser(Guid userId, string token);

}
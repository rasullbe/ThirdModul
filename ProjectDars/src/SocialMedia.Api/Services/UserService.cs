using SocialMedia.Api.Dtos;
using SocialMedia.Api.Repositories;
namespace SocialMedia.Api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository UserRepository;
    private readonly ITokenService TokenService;
    private readonly IPostRepository PostRepository;

    public UserService()
    {
        PostRepository = new PostRepository();
        TokenService = new TokenService();
        UserRepository = new UserRepository();
    }
    public bool BlockUser(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public bool ChangeRole(Guid userId, string newRole, string token)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUser(Guid userId, string token)
    {
        throw new NotImplementedException();
    }

    public bool DeleteUserPost(Guid postId, string token)
    {
        throw new NotImplementedException();
    }

    public List<UserGetDto>? GetAllUsers(string token)
    {
        throw new NotImplementedException();
    }
}

using AzureTestProj.Repositories.Base;
using AzureTestProj.Services.Base;

namespace AzureTestProj.Services;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public Task Create(Guid id, string name, string surname)
    {
        return userRepository.Create(id, name, surname);
    }

    public Task Delete(Guid id)
    {
        return userRepository.Delete(id);
    }
}
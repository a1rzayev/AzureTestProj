using AzureTestProj.Repositories.Base;

namespace AzureTestProj.Repositories;

public class UserRepository : IUserRepository
{
    public Task Create(Guid id, string name, string surname)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}

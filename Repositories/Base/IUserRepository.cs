namespace AzureTestProj.Repositories.Base;

public interface IUserRepository{
    Task Create(Guid id, string name, string surname);
    Task Delete(Guid id);
}
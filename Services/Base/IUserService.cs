namespace AzureTestProj.Services.Base;

public interface IUserService{
    Task Create(Guid id, string name, string surname);
    Task Delete(Guid id);
}
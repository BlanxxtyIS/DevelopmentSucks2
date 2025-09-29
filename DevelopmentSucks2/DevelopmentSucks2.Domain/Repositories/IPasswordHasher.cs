namespace DevelopmentSucks2.Domain.Repositories;

public interface IPasswordHasher
{
    public string Hash(string password);
    public bool Verify(string hash, string password);
}

namespace LibraryAppBackend.Application.Services;

public interface IHashingService
{
    public (byte[] passwordHash, byte[] passwordSalt) CreatePasswordHash(string password);
    public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

    public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
}
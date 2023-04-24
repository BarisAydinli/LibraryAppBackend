using LibraryAppBackend.Application.Services;

namespace LibraryAppBackend.Infrastructure.Services;

public class HashingService : IHashingService
{
    public (byte[] passwordHash, byte[] passwordSalt) CreatePasswordHash(string password)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512();
        
        var passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        var passwordSalt = hmac.Key;
        
        return (passwordHash, passwordSalt);
    }
    
    public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512();
        
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        passwordSalt = hmac.Key;
    }

    public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt);
        
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        return computedHash.Equals(passwordHash);
    }
}
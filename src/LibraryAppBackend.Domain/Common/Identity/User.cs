namespace LibraryAppBackend.Domain.Common.Identity;

public class User : Entity
{
    public ICollection<OperationClaim> OperationClaims { get; set; } = new List<OperationClaim>();
    
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public byte[] PasswordSalt { get; set; } = null!;
    public byte[] PasswordHash { get; set; } = null!;
}
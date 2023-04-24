namespace LibraryAppBackend.Domain.Common.Identity;

public sealed class OperationClaim : Entity
{
    public ICollection<User> Users { get; set; } = new List<User>();
    
    public string Name { get; set; }
}
using LibraryAppBackend.Domain.Common.Identity;

namespace LibraryAppBackend.Domain.Common;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.Empty;

    public Guid UserId { get; set; } = Guid.Empty;
    public User User { get; set; } = null!;
    
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
    public bool Status { get; set; }
}
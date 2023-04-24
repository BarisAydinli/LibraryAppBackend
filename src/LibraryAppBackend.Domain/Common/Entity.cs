namespace LibraryAppBackend.Domain.Common;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.Empty;

    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdatedAt { get; set; }
    public bool Status { get; set; } = true;
}
using LibraryAppBackend.Domain.Common;

namespace LibraryAppBackend.Domain.Entities;

public sealed class Loan : Entity
{
    public Guid BookId { get; set; } = Guid.Empty;
    public Book Book { get; set; } = null!;
}
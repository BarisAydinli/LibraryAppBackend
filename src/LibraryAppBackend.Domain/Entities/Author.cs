using LibraryAppBackend.Domain.Common;

namespace LibraryAppBackend.Domain.Entities;

public sealed class Author : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
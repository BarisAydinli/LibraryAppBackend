using LibraryAppBackend.Domain.Common;

namespace LibraryAppBackend.Domain.Entities;

public sealed class Category : Entity
{
    public String Name { get; set; } = string.Empty;
    
    public Boolean IsSubCategory { get; set; }
}
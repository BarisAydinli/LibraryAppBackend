using LibraryAppBackend.Domain.Common;

namespace LibraryAppBackend.Domain.Entities;

public sealed class Book : Entity
{
    public Guid AuthorId { get; set; } = Guid.Empty;
    public Author Author { get; set; } = null!;

    public ICollection<Category> Categories { get; set; } = new List<Category>();

    public string Isbn { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string PageNumber { get; set; } = string.Empty;

    public string CoverPath { get; set; } = string.Empty;

    public string Language { get; set; } = string.Empty;

    public string PublishDate { get; set; } = string.Empty;
    
    public bool Available { get; set; }
}
using LibraryAppBackend.Domain.Common.Identity;
using LibraryAppBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppBackend.Application.Services.Data;

public interface IApplicationDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Loan> Loans { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
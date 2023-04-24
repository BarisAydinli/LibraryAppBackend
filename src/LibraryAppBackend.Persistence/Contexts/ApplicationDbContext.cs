using LibraryAppBackend.Application.Services.Data;
using LibraryAppBackend.Domain.Common.Identity;
using LibraryAppBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAppBackend.Persistence.Contexts;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<OperationClaim> OperationClaims { get; set; } = null!;
    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Author> Authors { get; set; } = null!; 
    public DbSet<Publisher> Publishers { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Loan> Loans { get; set; } = null!;
}
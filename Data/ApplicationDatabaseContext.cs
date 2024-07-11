using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ApplicationDatabaseContext : DbContext
{
    public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> dbContextOptions) 
    : base(dbContextOptions) {}    public DbSet<Member> Members { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Visit> Visits { get; set; }
}
using Microsoft.EntityFrameworkCore;
using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Database;

public class ProgrammersInsideContext : DbContext
{
    public ProgrammersInsideContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProgrammersInsideContext).Assembly);
    }

    public DbSet<User> Users {get; set;} = null!;
}

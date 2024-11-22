using Microsoft.EntityFrameworkCore;
using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Database;

public class ProgrammersInsideContext : DbContext
{
    public ProgrammersInsideContext(DbContextOptions options) : base(options) {}
    public DbSet<User> Users {get; set;} = null!;
}

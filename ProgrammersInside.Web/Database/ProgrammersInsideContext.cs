using Microsoft.EntityFrameworkCore;
using ProgrammersInside.Web.Core.Models;

namespace ProgrammersInside.Web.Database;

public class ProgrammersInsideContext : DbContext
{
    public DbSet<User> Users {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=wwwroot/Content/Data/ProgrammersInside.db");

        base.OnConfiguring(optionsBuilder);
    }

}

using Microsoft.EntityFrameworkCore;
using ProgrammersInside.Data.Dmos;

namespace ProgrammersInside.Data;

public class ProgrammersInsideContext : DbContext
{
    public DbSet<User> Users {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=DatabaseFile/ProgrammersInside.db");

        base.OnConfiguring(optionsBuilder);
    }

}

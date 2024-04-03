using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace ConsoleAppWithDb;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseMySql("server=localhost;database=myDb;user=root;password=password", new MySqlServerVersion(new Version(8, 0, 21)));
    }

    public DbSet<User> Users { get; set; }
}

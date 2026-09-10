using Lesson6_EF_DbFirst.DAL;
using Microsoft.EntityFrameworkCore;

namespace Lesson6_EF_DbFirst.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connStr = "Data Source=STHQ012D-01;Initial Catalog=EF_LESSON6_DBFirst;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer(connStr); 

        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Product> Products{ get; set; }

}

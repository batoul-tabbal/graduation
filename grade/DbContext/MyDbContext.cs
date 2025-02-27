using System.Data.Entity;
using grade.Repository;
public class MyDbContext : DbContext
{
    public MyDbContext() : base("name=MyDbContext") 
    {
    }

    public DbSet<Item> MyItems { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}


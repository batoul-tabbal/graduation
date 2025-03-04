using System.Data.Entity;
using grade.Repository;
public class MyDbContext : DbContext
{
    public MyDbContext() : base("name=MyDbContext") 
    {
    }

    public DbSet<Repo> Repos { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Repo>().HasMany(r => r.Sections).WithRequired(s => s.Repos);

        modelBuilder.Entity<Section>().HasMany(s => s.Categories).WithRequired(c => c.Sections);

        modelBuilder.Entity<Category>().HasMany(c => c.Items).WithMany(i => i.Categories);
        modelBuilder.Entity<Category>().HasOptional(c => c.ParentCategory).WithMany(c => c.SubCategories).HasForeignKey(c => c.ParentId);
        modelBuilder.Entity<Section>().HasMany(s => s.Shelves).WithRequired(sh => sh.Sections);
    }
}


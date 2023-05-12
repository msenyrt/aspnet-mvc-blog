using Blog.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web.Mvc.Data;

public class BlogDbContext : DbContext
{
    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<PostComment> PostComments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Page> Pages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDb; Database=BlogDb;";
        builder.UseSqlServer(connectionString);

        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // FluentAPI ile bir entity modelinin özellikleri ayarlanabilir.
        modelBuilder.Entity<Category>().Property("Id").UseIdentityColumn();
        modelBuilder.Entity<Category>().Property("Name").IsRequired().HasMaxLength(100);

        // Seed: Örnek test verilerinin eklenmesi
        //modelBuilder.Entity<Category>().HasData(new Category() { Id = 1, Name = "TEST"});
        //DbSeeder.SeedTestData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

}


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
    public DbSet<PostImage> PostImages { get; set; }
    public DbSet<Setting> Settings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryPost> CategoryPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDb; Database=BlogDb;";
        builder.UseSqlServer(connectionString);

        base.OnConfiguring(builder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        DbSeeder.Seed(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

}


using forumApp.Models;
using Microsoft.EntityFrameworkCore;

namespace forumApp.Repository;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<Topic>().ToTable("Topic");
        modelBuilder.Entity<Post>().ToTable("Post");
        modelBuilder.Entity<Like>().ToTable("Like");
        modelBuilder.Entity<Comment>().ToTable("Comment");
    }
}
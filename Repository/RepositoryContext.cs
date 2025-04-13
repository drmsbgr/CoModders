using System.Reflection;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Rule> Rules { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<ForumGroup> ForumGroups { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Entities.Thread> Threads { get; set; }
    public DbSet<Forum> Forums { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

using AgriPro.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriPro.Api.Data;

public class AgriProDbContext : DbContext
{
    public AgriProDbContext(DbContextOptions<AgriProDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Investment> Investments => Set<Investment>();
    public DbSet<FarmTask> FarmTasks => Set<FarmTask>();
    public DbSet<Expense> Expenses => Set<Expense>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductImage> ProductImages => Set<ProductImage>();
    public DbSet<ProductReport> ProductReports => Set<ProductReport>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Projects)
            .WithOne(p => p.Farmer)
            .HasForeignKey(p => p.FarmerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Project>()
            .HasMany(p => p.Tasks)
            .WithOne(t => t.Project)
            .HasForeignKey(t => t.ProjectId);

        modelBuilder.Entity<Project>()
            .HasMany(p => p.Expenses)
            .WithOne(e => e.Project)
            .HasForeignKey(e => e.ProjectId);

        modelBuilder.Entity<Project>()
            .HasMany(p => p.Investments)
            .WithOne(i => i.Project)
            .HasForeignKey(i => i.ProjectId);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.Images)
            .WithOne(i => i.Product)
            .HasForeignKey(i => i.ProductId);

        modelBuilder.Entity<Product>()
            .HasMany(p => p.Reports)
            .WithOne(r => r.Product)
            .HasForeignKey(r => r.ProductId);

        base.OnModelCreating(modelBuilder);
    }
}

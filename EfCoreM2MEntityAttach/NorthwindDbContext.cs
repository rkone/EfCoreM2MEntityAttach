using EfCoreM2MEntityAttach.Models;
using Microsoft.EntityFrameworkCore;

public class NorthwindDbContext : DbContext
{
    public NorthwindDbContext() { }
    public NorthwindDbContext(DbContextOptions options) : base(options) { }       
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Territory> Territories => Set<Territory>();   
}

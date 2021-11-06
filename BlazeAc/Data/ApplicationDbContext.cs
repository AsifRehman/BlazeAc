using BlazeAc.Data;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<ProductCateg> ProductCategs { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
}


public class GreyDbContext : DbContext
{
    public GreyDbContext(DbContextOptions<GreyDbContext> options) : base(options)
    {
    }
    public DbSet<ProductCateg> ProductCategs { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
}
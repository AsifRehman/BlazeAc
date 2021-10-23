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
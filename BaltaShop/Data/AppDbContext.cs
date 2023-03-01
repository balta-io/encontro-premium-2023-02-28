using BaltaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BaltaShop.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
}
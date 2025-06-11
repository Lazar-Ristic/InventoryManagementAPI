using InventoryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
}

using CreateProduct.Models;
using Microsoft.EntityFrameworkCore;

namespace CreateProduct.Data;

public class excrisedbcontext: DbContext
{
    public excrisedbcontext(DbContextOptions<excrisedbcontext> options):base(options)
    {}
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Product> Products { get; set; }
    
    public DbSet<Order> Orders { get; set; }
    
    public DbSet<OrderDetail> OrderDetails { get; set; }
}
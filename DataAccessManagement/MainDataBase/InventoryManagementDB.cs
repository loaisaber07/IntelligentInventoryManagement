using DataAccessManagement.Entity;
using DataAccessManagement.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManagement.MainDataBase;

    public class InventoryManagementDB  :IdentityDbContext<User>
    {
    public InventoryManagementDB(DbContextOptions<InventoryManagementDB> options) : base(options)
    {
        
    }
    public DbSet<InventoryItem> InventoryItems { get; set; } 
    public DbSet<Supplier> Suppliers { get; set; }  
    public DbSet<Order> Orders { get; set; }  
    public DbSet<ItemSupplier> ItemSuppliers { get; set; } 
    public DbSet<OrderItem> OrderItems { get; set; }  
    public DbSet<Warehouse> Warehouses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ItemSupplierConfiguration()); 
        builder.ApplyConfiguration(new OrderItemConfiguration());
    }
}


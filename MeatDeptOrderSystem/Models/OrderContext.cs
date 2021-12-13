using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        { }

        public DbSet<OrderItem> OrderItems { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasData(
                    new OrderItem
                    {
                        OrderItemId = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        Phone = "5553334444",
                        ItemName = "Turkey",
                        ItemBrand = "hy-vee",
                        Quantity = 2,
                        Weight = 12,
                        pickupDate = DateTime.Today,
                        LocatedIn = OrderItem.Locations.none,
                        IsReady = true
                    }
                );
        }
          
               
        
    }
}

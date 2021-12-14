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
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Location> Locations { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "ready", Name = "Ready" },
                new Status { StatusId = "on order", Name = "On Order" },
                new Status { StatusId = "complete", Name = "Complete" },
                new Status { StatusId = "overdue", Name = "Overdue" },
                new Status { StatusId = "placed", Name = "Order Placed" });

            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = "meatCooler", Name = "Meat Cooler" },
                new Location { LocationId = "seafoodCooler", Name = "Seafood Cooler" },
                new Location { LocationId = "meatFreezer", Name = "Meat Freezer" },
                new Location { LocationId = "meatAndCheeseCooler", Name = "Meat and Cheese Cooler" },
                new Location { LocationId = "unPicked", Name = "Not Yet Picked"}
                );

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
                        Weight = "12lb",
                        pickupDate = DateTime.Today,
                        LocationId = "meatCooler",
                        StatusId = "ready"

                    },
                    new OrderItem
                    {
                        OrderItemId = 2,
                        FirstName = "Jane",
                        LastName = "Doe",
                        Phone = "5553335544",
                        ItemName = "Ham",
                        ItemBrand = "hy-vee",
                        Quantity = 1,
                        Weight = "12lb",
                        pickupDate = DateTime.Parse("08/15/2021 08:30 AM"),
                        LocationId = "unPicked",
                        StatusId = "on order"
                    },
                    new OrderItem
                    {
                        OrderItemId = 6,
                        FirstName = "Mark",
                        LastName = "Doe",
                        Phone = "5553335566",
                        ItemName = "Ham steak",
                        ItemBrand = "hy-vee",
                        Quantity = 1,
                        pickupDate = DateTime.Parse("12/15/2021 08:30 AM"),
                        LocationId = "unPicked",
                        StatusId = "placed"
                    },
                    new OrderItem
                    {
                        OrderItemId = 5,
                        FirstName = "Mark",
                        LastName = "Brandanawitz",
                        Phone = "5553335566",
                        ItemName = "Pigs feet",
                        Quantity = 1,
                        pickupDate = DateTime.Parse("12/15/2021 08:30 AM"),
                        LocationId = "unPicked",
                        StatusId = "placed",
                        CuttingInstructions= "cut into 3 pieces",
                        PackagingInstructions="6 pieces to a package",
                        OtherComments="They want 1 whole case"
                    },
                    new OrderItem
                    {
                        OrderItemId = 4,
                        FirstName = "Jack",
                        LastName = "Doe",
                        Phone = "5552235566",
                        ItemName = "Boneless Rib Roast",
                        Quantity = 1,
                        Weight = "6lb",
                        pickupDate = DateTime.Parse("12/24/2021 08:30 AM"),
                        LocationId = "unPicked",
                        StatusId = "placed",
                        CuttingInstructions = "trim a little extra fat off"
                    }


                );
        }
          
               
        
    }
}

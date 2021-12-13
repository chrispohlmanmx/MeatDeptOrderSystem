﻿// <auto-generated />
using System;
using MeatDeptOrderSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeatDeptOrderSystem.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20211213015811_seedOrders")]
    partial class seedOrders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MeatDeptOrderSystem.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CuttingInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnOrder")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReady")
                        .HasColumnType("bit");

                    b.Property<string>("ItemBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocatedIn")
                        .HasColumnType("int");

                    b.Property<string>("OtherComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackagingInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<DateTime>("orderedOnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("pickupDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderItemId");

                    b.HasIndex("userId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            FirstName = "John",
                            IsComplete = false,
                            IsOnOrder = false,
                            IsReady = true,
                            ItemBrand = "hy-vee",
                            ItemName = "Turkey",
                            LastName = "Doe",
                            LocatedIn = 0,
                            Phone = "5553334444",
                            Quantity = 2,
                            Weight = 12.0,
                            orderedOnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            pickupDate = new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            OrderItemId = 2,
                            FirstName = "Jane",
                            IsComplete = false,
                            IsOnOrder = false,
                            IsReady = false,
                            ItemBrand = "hy-vee",
                            ItemName = "Ham",
                            LastName = "Doe",
                            LocatedIn = 0,
                            Phone = "5553335544",
                            Quantity = 1,
                            Weight = 12.0,
                            orderedOnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            pickupDate = new DateTime(2021, 8, 15, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            OrderItemId = 6,
                            FirstName = "Mark",
                            IsComplete = false,
                            IsOnOrder = false,
                            IsReady = false,
                            ItemBrand = "hy-vee",
                            ItemName = "Ham steak",
                            LastName = "Doe",
                            LocatedIn = 0,
                            Phone = "5553335566",
                            Quantity = 1,
                            Weight = 0.0,
                            orderedOnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            pickupDate = new DateTime(2021, 12, 15, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            OrderItemId = 5,
                            CuttingInstructions = "cut into 3 pieces",
                            FirstName = "Mark",
                            IsComplete = false,
                            IsOnOrder = false,
                            IsReady = false,
                            ItemName = "Pigs feet",
                            LastName = "Brandanawitz",
                            LocatedIn = 0,
                            OtherComments = "They want 1 whole case",
                            PackagingInstructions = "6 pieces to a package",
                            Phone = "5553335566",
                            Quantity = 1,
                            Weight = 0.0,
                            orderedOnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            pickupDate = new DateTime(2021, 12, 15, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            OrderItemId = 4,
                            CuttingInstructions = "trim a little extra fat off",
                            FirstName = "Jack",
                            IsComplete = false,
                            IsOnOrder = false,
                            IsReady = false,
                            ItemName = "Boneless Rib Roast",
                            LastName = "Doe",
                            LocatedIn = 0,
                            Phone = "5552235566",
                            Quantity = 1,
                            Weight = 6.0,
                            orderedOnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            pickupDate = new DateTime(2021, 12, 24, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MeatDeptOrderSystem.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MeatDeptOrderSystem.Models.OrderItem", b =>
                {
                    b.HasOne("MeatDeptOrderSystem.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeatDeptOrderSystem.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: false),
                    ItemBrand = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    pickupDate = table.Column<DateTime>(nullable: false),
                    orderedOnDate = table.Column<DateTime>(nullable: false),
                    StatusId = table.Column<string>(nullable: false),
                    LocationId = table.Column<string>(nullable: false),
                    CuttingInstructions = table.Column<string>(nullable: true),
                    PackagingInstructions = table.Column<string>(nullable: true),
                    OtherComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "Name" },
                values: new object[,]
                {
                    { "meatCooler", "Meat Cooler" },
                    { "seafoodCooler", "Seafood Cooler" },
                    { "meatFreezer", "Meat Freezer" },
                    { "meatAndCheeseCooler", "Meat and Cheese Cooler" },
                    { "unPicked", "Not Yet Picked" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { "ready", "Ready" },
                    { "on order", "On Order" },
                    { "complete", "Complete" },
                    { "overdue", "Overdue" },
                    { "placed", "Order Placed" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "CuttingInstructions", "FirstName", "ItemBrand", "ItemName", "LastName", "LocationId", "OtherComments", "PackagingInstructions", "Phone", "Quantity", "StatusId", "UserId", "UserId1", "Weight", "orderedOnDate", "pickupDate" },
                values: new object[,]
                {
                    { 1, null, "John", "hy-vee", "Turkey", "Doe", "meatCooler", null, null, "5553334444", 2, "ready", 0, null, 12.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, null, "Jane", "hy-vee", "Ham", "Doe", "unPicked", null, null, "5553335544", 1, "on order", 0, null, 12.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 15, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, "Mark", "hy-vee", "Ham steak", "Doe", "unPicked", null, null, "5553335566", 1, "placed", 0, null, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 15, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "cut into 3 pieces", "Mark", null, "Pigs feet", "Brandanawitz", "unPicked", "They want 1 whole case", "6 pieces to a package", "5553335566", 1, "placed", 0, null, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 15, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "trim a little extra fat off", "Jack", null, "Boneless Rib Roast", "Doe", "unPicked", null, null, "5552235566", 1, "placed", 0, null, 6.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 24, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_LocationId",
                table: "OrderItems",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_StatusId",
                table: "OrderItems",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_UserId1",
                table: "OrderItems",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

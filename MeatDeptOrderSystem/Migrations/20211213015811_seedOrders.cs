using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeatDeptOrderSystem.Migrations
{
    public partial class seedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "CuttingInstructions", "FirstName", "IsComplete", "IsOnOrder", "IsReady", "ItemBrand", "ItemName", "LastName", "LocatedIn", "OtherComments", "PackagingInstructions", "Phone", "Quantity", "Status", "Weight", "orderedOnDate", "pickupDate", "userId" },
                values: new object[,]
                {
                    { 7, null, "Jane", false, false, false, "hy-vee", "Ham", "Doe", 0, null, null, "5553335544", 1, null, 12.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 15, 8, 30, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, null, "Mark", false, false, false, "hy-vee", "Ham steak", "Doe", 0, null, null, "5553335566", 1, null, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 15, 8, 30, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "cut into 3 pieces", "Mark", false, false, false, null, "Pigs feet", "Brandanawitz", 0, "They want 1 whole case", "6 pieces to a package", "5553335566", 1, null, 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 15, 8, 30, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "trim a little extra fat off", "Jack", false, false, false, null, "Boneless Rib Roast", "Doe", 0, null, null, "5552235566", 1, null, 6.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 24, 8, 30, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 6);
        }
    }
}

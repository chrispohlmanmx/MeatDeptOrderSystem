using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeatDeptOrderSystem.Migrations
{
    public partial class seedOrderItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "CuttingInstructions", "FirstName", "IsComplete", "IsOnOrder", "IsReady", "ItemBrand", "ItemName", "LastName", "LocatedIn", "OtherComments", "PackagingInstructions", "Phone", "Quantity", "Status", "Weight", "orderedOnDate", "pickupDate", "userId" },
                values: new object[] { 1, null, "John", false, false, true, "hy-vee", "Turkey", "Doe", 0, null, null, "5553334444", 2, null, 12.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Local), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1);
        }
    }
}

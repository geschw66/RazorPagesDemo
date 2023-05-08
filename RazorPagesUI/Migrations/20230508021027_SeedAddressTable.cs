using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesUI.Migrations
{
    public partial class SeedAddressTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "State", "StreetAddress", "ZipCode" },
                values: new object[] { 1, "University City", "MO", "8822 Delmar Blvd", "63124" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

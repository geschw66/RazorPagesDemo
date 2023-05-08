using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesUI.Migrations
{
    public partial class SeedListOfRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "State", "StreetAddress", "ZipCode" },
                values: new object[] { 2, "Mockingbird Heights", "NH", "1313 MockingBird Lane", "30123" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "State", "StreetAddress", "ZipCode" },
                values: new object[] { 3, "Edwardsville", "IL", "425 Grandview Dr.", "62025" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DHLOne.Migrations
{
    /// <inheritdoc />
    public partial class SeedItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "itemId", "itemDescription", "itemName" },
                values: new object[,]
                {
                    { 1, "To hit things into the wall", "Hammer" },
                    { 2, "To call somebody", "Phone" },
                    { 3, "To hold water in place", "Cup" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "itemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "itemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "itemId",
                keyValue: 3);
        }
    }
}

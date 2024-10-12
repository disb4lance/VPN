using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagmentService.Migrations
{
    /// <inheritdoc />
    public partial class whr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2995d28f-e9d3-4d0a-9141-c573140aa95d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8eb3936-8090-4943-b6e2-45b3f81b63b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "530e931d-a7ec-4c1c-b00d-836e84f64014", null, "Administrator", "ADMINISTRATOR" },
                    { "8c181c01-f0da-47a0-a861-74f1bd209d9a", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "530e931d-a7ec-4c1c-b00d-836e84f64014");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c181c01-f0da-47a0-a861-74f1bd209d9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2995d28f-e9d3-4d0a-9141-c573140aa95d", null, "Manager", "MANAGER" },
                    { "e8eb3936-8090-4943-b6e2-45b3f81b63b6", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}

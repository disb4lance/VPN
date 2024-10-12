using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagmentService.Migrations
{
    /// <inheritdoc />
    public partial class qwerr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a6f86fa-1851-41bd-8963-d55db11b99d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc6dc51e-adef-4b27-beee-4ba3bd5e6545");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2995d28f-e9d3-4d0a-9141-c573140aa95d", null, "Manager", "MANAGER" },
                    { "e8eb3936-8090-4943-b6e2-45b3f81b63b6", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3a6f86fa-1851-41bd-8963-d55db11b99d9", null, "Administrator", "ADMINISTRATOR" },
                    { "bc6dc51e-adef-4b27-beee-4ba3bd5e6545", null, "Manager", "MANAGER" }
                });
        }
    }
}

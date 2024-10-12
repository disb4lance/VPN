using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagmentService.Migrations
{
    /// <inheritdoc />
    public partial class qqew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2db0c72a-20ed-4d62-b8b4-5342ddb9821f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad11310d-9fec-43d7-8564-01a2496aa958");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a6f86fa-1851-41bd-8963-d55db11b99d9", null, "Administrator", "ADMINISTRATOR" },
                    { "bc6dc51e-adef-4b27-beee-4ba3bd5e6545", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2db0c72a-20ed-4d62-b8b4-5342ddb9821f", null, "Manager", "MANAGER" },
                    { "ad11310d-9fec-43d7-8564-01a2496aa958", null, "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}

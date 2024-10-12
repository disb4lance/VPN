using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagmentService.Migrations
{
    /// <inheritdoc />
    public partial class newsrver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "141a5607-d252-4e76-bb97-c7760bc30aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee26fd6-0878-4c6c-8da8-7d5a59dd702c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2db0c72a-20ed-4d62-b8b4-5342ddb9821f", null, "Manager", "MANAGER" },
                    { "ad11310d-9fec-43d7-8564-01a2496aa958", null, "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "141a5607-d252-4e76-bb97-c7760bc30aec", null, "Administrator", "ADMINISTRATOR" },
                    { "5ee26fd6-0878-4c6c-8da8-7d5a59dd702c", null, "Manager", "MANAGER" }
                });
        }
    }
}

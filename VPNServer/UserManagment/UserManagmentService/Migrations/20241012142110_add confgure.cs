using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagmentService.Migrations
{
    /// <inheritdoc />
    public partial class addconfgure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "141a5607-d252-4e76-bb97-c7760bc30aec", null, "Administrator", "ADMINISTRATOR" },
                    { "5ee26fd6-0878-4c6c-8da8-7d5a59dd702c", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "141a5607-d252-4e76-bb97-c7760bc30aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ee26fd6-0878-4c6c-8da8-7d5a59dd702c");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WealthWaves.Migrations
{
    /// <inheritdoc />
    public partial class Identity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bb5c168-009c-4cca-8a5f-9b27fb3b6da6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4e70ac7-20e4-4d54-8afc-3540552a665e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c803c65-290d-4599-96b5-bdccecf2b1d5", null, "User", "USER" },
                    { "5199e9d9-67a1-4156-b8a8-5f15cd1c77b6", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c803c65-290d-4599-96b5-bdccecf2b1d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5199e9d9-67a1-4156-b8a8-5f15cd1c77b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8bb5c168-009c-4cca-8a5f-9b27fb3b6da6", null, "User", "USER" },
                    { "b4e70ac7-20e4-4d54-8afc-3540552a665e", null, "Admin", "ADMIN" }
                });
        }
    }
}

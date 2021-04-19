using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OfficeItemManagement.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Birthday", "Name", "Password", "Phone", "Sex", "Username" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "管理员", "rSWRBlqiTJoo31QNtJwSQzQHjVsrlqLdwSuz8JOyGk99NhG6", null, 0, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

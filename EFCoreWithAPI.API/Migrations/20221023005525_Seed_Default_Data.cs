using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreWithAPI.API.Migrations
{
    public partial class Seed_Default_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "Score" },
                values: new object[] { 1, "Hussein", "Issa", 1000.0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "Score" },
                values: new object[] { 2, "Hasan", "Issa", 80.0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "Score" },
                values: new object[] { 3, "Ramiz", "Issa", 85.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

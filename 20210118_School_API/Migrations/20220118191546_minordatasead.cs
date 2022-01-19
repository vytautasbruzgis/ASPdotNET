using Microsoft.EntityFrameworkCore.Migrations;

namespace _20210118_School_API.Migrations
{
    public partial class minordatasead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sex",
                value: "Male");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sex",
                value: null);
        }
    }
}

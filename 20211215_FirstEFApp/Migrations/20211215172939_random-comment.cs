using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211215_FirstEFApp.Migrations
{
    public partial class randomcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "toDos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "toDos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ToDoUntil",
                table: "toDos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "toDos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "toDos");

            migrationBuilder.DropColumn(
                name: "ToDoUntil",
                table: "toDos");
        }
    }
}

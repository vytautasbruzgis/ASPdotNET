using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211215_FirstEFApp.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "toDos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_toDos_CategoryId",
                table: "toDos",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_toDos_categories_CategoryId",
                table: "toDos",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_toDos_categories_CategoryId",
                table: "toDos");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropIndex(
                name: "IX_toDos_CategoryId",
                table: "toDos");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "toDos");
        }
    }
}

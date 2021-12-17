using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211215_EF_ShopApp.Migrations
{
    public partial class Data : Migration
    {
        //trink db ir 
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopItems_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 16, 17, 45, 59, 775, DateTimeKind.Utc).AddTicks(3091), 0, "Shop 1" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 16, 17, 45, 59, 775, DateTimeKind.Utc).AddTicks(3589), 0, "Shop 2" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 16, 17, 45, 59, 775, DateTimeKind.Utc).AddTicks(3641), 0, "Shop 3" });

            migrationBuilder.InsertData(
                table: "ShopItems",
                columns: new[] { "Id", "Created", "ExpiryDate", "IsDeleted", "Name", "ShopId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 16, 17, 45, 59, 776, DateTimeKind.Utc).AddTicks(1904), new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, "Item 1", 1 },
                    { 2, new DateTime(2021, 12, 16, 17, 45, 59, 777, DateTimeKind.Utc).AddTicks(8521), new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, "Item 2", 1 },
                    { 4, new DateTime(2021, 12, 16, 17, 45, 59, 777, DateTimeKind.Utc).AddTicks(8554), new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, "Item 4", 1 },
                    { 5, new DateTime(2021, 12, 16, 17, 45, 59, 777, DateTimeKind.Utc).AddTicks(8557), new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, "Item 5", 1 },
                    { 3, new DateTime(2021, 12, 16, 17, 45, 59, 777, DateTimeKind.Utc).AddTicks(8550), new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), 0, "Item 3", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopItems_ShopId",
                table: "ShopItems",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItems");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}

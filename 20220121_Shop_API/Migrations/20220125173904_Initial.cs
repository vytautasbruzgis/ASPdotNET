using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20220121_Shop_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShopItem_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Televizorius", 1099m },
                    { 2, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Šaldytuvas", 499.5m }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Akropolis" },
                    { 2, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), "Ozas" }
                });

            migrationBuilder.InsertData(
                table: "ShopItem",
                columns: new[] { "Id", "Created", "IsDeleted", "ItemId", "LastModified", "Price", "ShopId" },
                values: new object[] { 1, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, 1, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 499.5m, 1 });

            migrationBuilder.InsertData(
                table: "ShopItem",
                columns: new[] { "Id", "Created", "IsDeleted", "ItemId", "LastModified", "Price", "ShopId" },
                values: new object[] { 3, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, 2, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 1199.99m, 1 });

            migrationBuilder.InsertData(
                table: "ShopItem",
                columns: new[] { "Id", "Created", "IsDeleted", "ItemId", "LastModified", "Price", "ShopId" },
                values: new object[] { 2, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), false, 1, new DateTime(2022, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), 489.5m, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ShopItem_ItemId",
                table: "ShopItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopItem_ShopId",
                table: "ShopItem",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopItem");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}

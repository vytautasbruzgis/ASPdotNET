using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211215_EF_ShopApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ItemTags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false),
                    ShopItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTags", x => new { x.TagId, x.ShopItemId });
                    table.ForeignKey(
                        name: "FK_ItemTags_ShopItems_ShopItemId",
                        column: x => x.ShopItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(601), false, "Shop 1" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[] { 2, new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(1120), false, "Shop 2" });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[] { 3, new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(1123), false, "Shop 3" });

            migrationBuilder.InsertData(
                table: "ShopItems",
                columns: new[] { "Id", "Created", "ExpiryDate", "IsDeleted", "Name", "ShopId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(8339), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Item 1", 1 },
                    { 2, new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5636), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Item 2", 1 },
                    { 4, new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5669), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Item 4", 1 },
                    { 5, new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5672), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Item 5", 1 },
                    { 3, new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5664), new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Local), false, "Item 3", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemTags_ShopItemId",
                table: "ItemTags",
                column: "ShopItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopItems_ShopId",
                table: "ShopItems",
                column: "ShopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemTags");

            migrationBuilder.DropTable(
                name: "ShopItems");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}

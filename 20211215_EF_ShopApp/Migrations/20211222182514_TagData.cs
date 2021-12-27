using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211215_EF_ShopApp.Migrations
{
    public partial class TagData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 240, DateTimeKind.Utc).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 242, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 242, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 242, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 242, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 240, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 240, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 25, 14, 240, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Created", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 22, 18, 25, 14, 239, DateTimeKind.Utc).AddTicks(5537), false, "Tag 1" },
                    { 2, new DateTime(2021, 12, 22, 18, 25, 14, 239, DateTimeKind.Utc).AddTicks(6048), false, "Tag 2" },
                    { 3, new DateTime(2021, 12, 22, 18, 25, 14, 239, DateTimeKind.Utc).AddTicks(6051), false, "Tag 3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 544, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 12, 22, 18, 10, 11, 542, DateTimeKind.Utc).AddTicks(1123));
        }
    }
}

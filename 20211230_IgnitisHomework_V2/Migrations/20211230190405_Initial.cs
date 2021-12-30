using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211230_IgnitisHomework_V2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttributeOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeOption_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationAttribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    SelectedOptionId = table.Column<int>(type: "int", nullable: false),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationAttribute_Attribute_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attribute",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationAttribute_Registration_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registration",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Attribute",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Reikia atlikti rangos darbus" },
                    { 2, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Rangos darbus atliks" },
                    { 3, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Verslo klientas" },
                    { 4, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Skaičiavimo metodas" },
                    { 5, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Svarbus klientas" }
                });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified" },
                values: new object[] { 1, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "AttributeOption",
                columns: new[] { "Id", "AttributeId", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Taip" },
                    { 2, 1, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ne" },
                    { 3, 2, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Metinis rangovas" },
                    { 4, 3, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Taip" },
                    { 5, 3, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ne" },
                    { 6, 4, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Automatinis" },
                    { 7, 5, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Taip" },
                    { 8, 5, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "Ne" },
                    { 9, 5, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), "" }
                });

            migrationBuilder.InsertData(
                table: "RegistrationAttribute",
                columns: new[] { "Id", "AttributeId", "Created", "IsDeleted", "LastModified", "RegistrationId", "SelectedOptionId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 1 },
                    { 2, 2, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 3 },
                    { 3, 3, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 5 },
                    { 4, 4, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 6 },
                    { 5, 5, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), 1, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOption_AttributeId",
                table: "AttributeOption",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationAttribute_AttributeId",
                table: "RegistrationAttribute",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationAttribute_RegistrationId",
                table: "RegistrationAttribute",
                column: "RegistrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeOption");

            migrationBuilder.DropTable(
                name: "RegistrationAttribute");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "Registration");
        }
    }
}

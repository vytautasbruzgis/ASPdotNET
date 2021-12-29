using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211228_IgnitisHomeWork.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculationTypeModel",
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
                    table.PrimaryKey("PK_CalculationTypeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractorTypeModel",
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
                    table.PrimaryKey("PK_ContractorTypeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerImportanceModel",
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
                    table.PrimaryKey("PK_CustomerImportanceModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationattributesModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HasContractWork = table.Column<bool>(type: "bit", nullable: false),
                    ContractorTypeId = table.Column<int>(type: "int", nullable: false),
                    IsBusinessClient = table.Column<bool>(type: "bit", nullable: false),
                    CalculationTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerImportanceId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationattributesModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationattributesModel_CalculationTypeModel_CalculationTypeId",
                        column: x => x.CalculationTypeId,
                        principalTable: "CalculationTypeModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationattributesModel_ContractorTypeModel_ContractorTypeId",
                        column: x => x.ContractorTypeId,
                        principalTable: "ContractorTypeModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationattributesModel_CustomerImportanceModel_CustomerImportanceId",
                        column: x => x.CustomerImportanceId,
                        principalTable: "CustomerImportanceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CalculationTypeModel",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Automatinis" });

            migrationBuilder.InsertData(
                table: "ContractorTypeModel",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "Metinis rangovas" });

            migrationBuilder.InsertData(
                table: "CustomerImportanceModel",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[] { 1, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Local), "" });

            migrationBuilder.InsertData(
                table: "RegistrationattributesModel",
                columns: new[] { "Id", "CalculationTypeId", "ContractorTypeId", "Created", "CustomerImportanceId", "HasContractWork", "IsBusinessClient", "IsDeleted", "LastModified" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationattributesModel_CalculationTypeId",
                table: "RegistrationattributesModel",
                column: "CalculationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationattributesModel_ContractorTypeId",
                table: "RegistrationattributesModel",
                column: "ContractorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationattributesModel_CustomerImportanceId",
                table: "RegistrationattributesModel",
                column: "CustomerImportanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationattributesModel");

            migrationBuilder.DropTable(
                name: "CalculationTypeModel");

            migrationBuilder.DropTable(
                name: "ContractorTypeModel");

            migrationBuilder.DropTable(
                name: "CustomerImportanceModel");
        }
    }
}

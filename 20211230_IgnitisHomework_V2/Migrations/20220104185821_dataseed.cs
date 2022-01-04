using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20211230_IgnitisHomework_V2.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified" },
                values: new object[] { 2, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "RegistrationAttribute",
                columns: new[] { "Id", "AttributeId", "Created", "IsDeleted", "LastModified", "RegistrationId", "SelectedOptionId" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, 1 },
                    { 7, 2, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, 3 },
                    { 8, 3, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, 5 },
                    { 9, 4, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, 6 },
                    { 10, 5, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 4, 0, 0, 0, 0, DateTimeKind.Local), 2, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attribute",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "AttributeOption",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "RegistrationAttribute",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "LastModified" },
                values: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}

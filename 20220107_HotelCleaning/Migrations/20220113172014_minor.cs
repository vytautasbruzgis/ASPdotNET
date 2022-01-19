using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _20220107_HotelCleaning.Migrations
{
    public partial class minor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
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
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobType",
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
                    table.PrimaryKey("PK_JobType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskType",
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
                    table.PrimaryKey("PK_TaskType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    FloorsCount = table.Column<int>(type: "int", nullable: false),
                    RoomsInHotel = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    IsCheckedIn = table.Column<bool>(type: "bit", nullable: false),
                    IsCleaned = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitor_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    JobTypeId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Worker_JobType_JobTypeId",
                        column: x => x.JobTypeId,
                        principalTable: "JobType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Worker_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCheckedIn = table.Column<bool>(type: "bit", nullable: false),
                    IsCheckedOut = table.Column<bool>(type: "bit", nullable: false),
                    CheckedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Visitor_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HotelTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    CompleteUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TaskTypeId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelTask_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelTask_TaskType_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "TaskType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HotelTask_Worker_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Worker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Vilnius" },
                    { 2, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kaunas" },
                    { 3, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Klaipėda" }
                });

            migrationBuilder.InsertData(
                table: "JobType",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Kambarių valytojas" },
                    { 2, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Restorano darbuotojas" },
                    { 3, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Administratorius" }
                });

            migrationBuilder.InsertData(
                table: "TaskType",
                columns: new[] { "Id", "Created", "IsDeleted", "LastModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Išvalyti kambarį" },
                    { 2, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Papildyti minibarą" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Address", "CityId", "Created", "FloorsCount", "IsDeleted", "LastModified", "Name", "RoomsInHotel" },
                values: new object[,]
                {
                    { 1, "Konstitucijos pr. 5", 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 21, false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Radison SAS", 0 },
                    { 2, "Šaligatvio g. 5", 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 16, false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Lietuva", 0 },
                    { 3, "Kauno g. 5", 2, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 5, false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Daugirdas", 0 }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "CityId", "Created", "FirstName", "IsDeleted", "LastModified", "LastName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Vytautas", false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Bruzgis" },
                    { 2, 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Anelė", false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Čirūnaitė" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Created", "FloorNumber", "HotelId", "IsCheckedIn", "IsCleaned", "IsDeleted", "LastModified", "Name", "RoomNumber" },
                values: new object[] { 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, false, true, false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Karališkasis", 101 });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Created", "FloorNumber", "HotelId", "IsCheckedIn", "IsCleaned", "IsDeleted", "LastModified", "Name", "RoomNumber" },
                values: new object[] { 2, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, false, true, false, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), "Medaus puodynė", 102 });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_VisitorId",
                table: "Booking",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityId",
                table: "Hotel",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTask_RoomId",
                table: "HotelTask",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTask_TaskTypeId",
                table: "HotelTask",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTask_WorkerId",
                table: "HotelTask",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CityId",
                table: "Person",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelId",
                table: "Room",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_PersonId",
                table: "Visitor",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_JobTypeId",
                table: "Worker",
                column: "JobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Worker_PersonId",
                table: "Worker",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "HotelTask");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "TaskType");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "JobType");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}

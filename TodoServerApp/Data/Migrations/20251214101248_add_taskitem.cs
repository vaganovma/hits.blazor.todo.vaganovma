using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 14, 15, 12, 48, 25, DateTimeKind.Local).AddTicks(4190), "Описание задачи 1", null, "Задача 1" },
                    { 2, new DateTime(2025, 12, 14, 15, 12, 48, 25, DateTimeKind.Local).AddTicks(4206), "Описание задачи 2", null, "Задача 2" },
                    { 3, new DateTime(2025, 12, 14, 15, 12, 48, 25, DateTimeKind.Local).AddTicks(4208), "Описание задачи 3", null, "Задача 3" },
                    { 4, new DateTime(2025, 12, 14, 15, 12, 48, 25, DateTimeKind.Local).AddTicks(4210), "Описание задачи 4", null, "Задача 4" },
                    { 5, new DateTime(2025, 12, 14, 15, 12, 48, 25, DateTimeKind.Local).AddTicks(4212), "Описание задачи 5", null, "Задача 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}

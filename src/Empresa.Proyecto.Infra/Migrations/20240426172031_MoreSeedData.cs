using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Empresa.Proyecto.Infra.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified", "Name", "Value" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 1", "test 1" });

            migrationBuilder.InsertData(
                table: "SimpleEntity",
                columns: new[] { "Id", "Created", "Modified", "Name", "Value" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 2", "test 2" },
                    { 5, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 3", "test 3" },
                    { 6, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 4", "test 4" },
                    { 7, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 5", "test 5" },
                    { 8, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 6", "test 6" },
                    { 9, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 7", "test 7" },
                    { 10, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 8", "test 8" },
                    { 11, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 9", "test 9" },
                    { 12, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 10", "test 10" },
                    { 13, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 11", "test 11" },
                    { 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 12", "test 12" },
                    { 15, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 13", "test 13" },
                    { 16, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 14", "test 14" },
                    { 17, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 15", "test 15" },
                    { 18, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 16", "test 16" },
                    { 19, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 17", "test 17" },
                    { 20, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 18", "test 18" },
                    { 21, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 19", "test 19" },
                    { 22, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 20", "test 20" },
                    { 23, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 21", "test 21" },
                    { 24, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 22", "test 22" },
                    { 25, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 23", "test 23" },
                    { 26, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 24", "test 24" },
                    { 27, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 25", "test 25" },
                    { 28, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 26", "test 26" },
                    { 29, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 27", "test 27" },
                    { 30, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 28", "test 28" },
                    { 31, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 29", "test 29" },
                    { 32, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "test 30", "test 30" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "SimpleEntity",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified", "Name", "Value" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reconstruido", "Reconstruido" });
        }
    }
}

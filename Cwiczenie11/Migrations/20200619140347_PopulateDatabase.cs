using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenie11.Migrations
{
    public partial class PopulateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 11,
                column: "Birthdate",
                value: new DateTime(2020, 6, 19, 16, 3, 46, 841, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 22,
                column: "Birthdate",
                value: new DateTime(2020, 6, 19, 16, 3, 46, 843, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 33,
                column: "Birthdate",
                value: new DateTime(2020, 6, 19, 16, 3, 46, 843, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 1111,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(7489), new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 2222,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8384), new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 3333,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8408), new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 4444,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8413), new DateTime(2020, 6, 19, 16, 3, 46, 844, DateTimeKind.Local).AddTicks(8415) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 11,
                column: "Birthdate",
                value: new DateTime(2020, 6, 19, 16, 1, 45, 324, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 22,
                column: "Birthdate",
                value: new DateTime(2020, 6, 19, 16, 1, 45, 327, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 33,
                column: "Birthdate",
                value: new DateTime(2020, 6, 19, 16, 1, 45, 327, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 1111,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(565), new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 2222,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1533), new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 3333,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1559), new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IDPrescription",
                keyValue: 4444,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1564), new DateTime(2020, 6, 19, 16, 1, 45, 328, DateTimeKind.Local).AddTicks(1566) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenie11.Migrations
{
    public partial class AddedPresciptionAndPrescriptionMedicament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    IDPrescription = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    IdPatient = table.Column<int>(nullable: false),
                    IdDoctor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.IDPrescription);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Doctors_IdDoctor",
                        column: x => x.IdDoctor,
                        principalTable: "Doctors",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_IdPatient",
                        column: x => x.IdPatient,
                        principalTable: "Patients",
                        principalColumn: "IdPatient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionsMedicaments",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(nullable: false),
                    IdMedicament = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionsMedicaments", x => x.IdPrescription);
                    table.ForeignKey(
                        name: "FK_PrescriptionsMedicaments_Medicaments_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicaments",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionsMedicaments_Prescriptions_IdPrescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescriptions",
                        principalColumn: "IDPrescription",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_IdDoctor",
                table: "Prescriptions",
                column: "IdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_IdPatient",
                table: "Prescriptions",
                column: "IdPatient");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionsMedicaments_IdMedicament",
                table: "PrescriptionsMedicaments",
                column: "IdMedicament");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionsMedicaments");

            migrationBuilder.DropTable(
                name: "Prescriptions");
        }
    }
}

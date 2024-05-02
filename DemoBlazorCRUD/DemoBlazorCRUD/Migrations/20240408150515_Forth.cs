using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoBlazorCRUD.Migrations
{
    /// <inheritdoc />
    public partial class Forth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Consciousness",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Abroad",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AllergyHistory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BP",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BT",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HR",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MedicalHistory",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OperationTime",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Operator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalCondition",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RR",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SideEffects",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HealthEdu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthEdu", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthEdu");

            migrationBuilder.DropColumn(
                name: "Abroad",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AllergyHistory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BP",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BT",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "HR",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MedicalHistory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OperationTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Operator",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PhysicalCondition",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RR",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SideEffects",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Consciousness",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

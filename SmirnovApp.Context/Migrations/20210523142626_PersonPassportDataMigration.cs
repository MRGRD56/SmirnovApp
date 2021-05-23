using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmirnovApp.Context.Migrations
{
    public partial class PersonPassportDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LivingAddress",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PassportIssueDate",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PassportIssuedBy",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportSeries",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationAddress",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LivingAddress",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PassportIssueDate",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PassportIssuedBy",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PassportSeries",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "RegistrationAddress",
                table: "Persons");
        }
    }
}

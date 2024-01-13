using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppDay10.Migrations
{
    /// <inheritdoc />
    public partial class forth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "PatientHistory");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "PatientHistory");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "PatientHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "PatientHistory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "PatientHistory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "PatientHistory",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "PatientHistory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "PatientHistory",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "PatientHistory",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IDCard.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCollegeApplication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "CollegeApplications");

            migrationBuilder.AlterColumn<string>(
                name: "Course",
                table: "CollegeApplications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "CollegeApplications",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppliedOn",
                table: "CollegeApplications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "CollegeApplications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "CollegeApplications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PinCode",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RollNumber",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppliedOn",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "PinCode",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "RollNumber",
                table: "CollegeApplications");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "CollegeApplications");

            migrationBuilder.AlterColumn<string>(
                name: "Course",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "CollegeApplications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "CollegeApplications",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

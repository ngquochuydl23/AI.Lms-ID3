using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lms_ID3_BE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StudentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    StudentName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StartStudyingAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndStudyingAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ClassId = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Course",
                newName: "CourseId");
        }
    }
}

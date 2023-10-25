using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lms_ID3_BE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SubjectEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    SubjectName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TotalCreditCount = table.Column<int>(type: "integer", nullable: false),
                    TheoricalCreditCount = table.Column<int>(type: "integer", nullable: false),
                    PracticalCreditCount = table.Column<int>(type: "integer", nullable: false),
                    Compulsory = table.Column<bool>(type: "boolean", nullable: false),
                    FacultyName = table.Column<string>(type: "text", nullable: false),
                    SubjectEntityId = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Subject_SubjectEntityId",
                        column: x => x.SubjectEntityId,
                        principalTable: "Subject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectEntityId",
                table: "Subject",
                column: "SubjectEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}

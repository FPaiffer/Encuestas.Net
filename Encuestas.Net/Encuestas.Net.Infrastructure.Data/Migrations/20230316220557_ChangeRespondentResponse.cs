using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Encuestas.Net.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRespondentResponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerReferenceId",
                table: "RespondentResponse");

            migrationBuilder.AddColumn<string>(
                name: "AnswerText",
                table: "RespondentResponse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerText",
                table: "RespondentResponse");

            migrationBuilder.AddColumn<int>(
                name: "AnswerReferenceId",
                table: "RespondentResponse",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

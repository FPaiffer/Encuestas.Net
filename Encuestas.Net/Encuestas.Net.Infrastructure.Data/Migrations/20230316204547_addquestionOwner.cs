using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Encuestas.Net.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class addquestionOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionGoToId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionGoToId",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "QuestionGoToId",
                table: "Answer",
                newName: "QuestionGoTo");

            migrationBuilder.AddColumn<int>(
                name: "QuestionOwnerId",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionOwnerId",
                table: "Answer",
                column: "QuestionOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionOwnerId",
                table: "Answer",
                column: "QuestionOwnerId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionOwnerId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionOwnerId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "QuestionOwnerId",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "QuestionGoTo",
                table: "Answer",
                newName: "QuestionGoToId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionGoToId",
                table: "Answer",
                column: "QuestionGoToId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionGoToId",
                table: "Answer",
                column: "QuestionGoToId",
                principalTable: "Question",
                principalColumn: "Id");
        }
    }
}

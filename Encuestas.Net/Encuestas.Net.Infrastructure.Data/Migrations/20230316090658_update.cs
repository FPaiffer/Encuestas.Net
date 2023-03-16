using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Encuestas.Net.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "QuestionGoTo",
                table: "Answer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answer",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answer");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionGoTo",
                table: "Answer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Encuestas.Net.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RespondentResponse",
                table: "RespondentResponse");

            migrationBuilder.DropColumn(
                name: "QuestionGoTo",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "SurveyId",
                table: "Question",
                newName: "SectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_SurveyId",
                table: "Question",
                newName: "IX_Question_SectionId");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Answer",
                newName: "QuestionGoToId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                newName: "IX_Answer_QuestionGoToId");

            migrationBuilder.AlterColumn<int>(
                name: "AnswerReferenceId",
                table: "RespondentResponse",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<int>(
                name: "QuestionFatherId",
                table: "Question",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RespondentResponse",
                table: "RespondentResponse",
                columns: new[] { "Id", "RespondentReferenceId", "SurveyReferenceId", "QuestionReferenceId" });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SurveyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Section_Survey_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Survey",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionFatherId",
                table: "Question",
                column: "QuestionFatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Section_SurveyId",
                table: "Section",
                column: "SurveyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionGoToId",
                table: "Answer",
                column: "QuestionGoToId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Question_QuestionFatherId",
                table: "Question",
                column: "QuestionFatherId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Section_SectionId",
                table: "Question",
                column: "SectionId",
                principalTable: "Section",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionGoToId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Question_QuestionFatherId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Section_SectionId",
                table: "Question");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RespondentResponse",
                table: "RespondentResponse");

            migrationBuilder.DropIndex(
                name: "IX_Question_QuestionFatherId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "QuestionFatherId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "Question",
                newName: "SurveyId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_SectionId",
                table: "Question",
                newName: "IX_Question_SurveyId");

            migrationBuilder.RenameColumn(
                name: "QuestionGoToId",
                table: "Answer",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Answer_QuestionGoToId",
                table: "Answer",
                newName: "IX_Answer_QuestionId");

            migrationBuilder.AlterColumn<int>(
                name: "AnswerReferenceId",
                table: "RespondentResponse",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.AddColumn<int>(
                name: "QuestionGoTo",
                table: "Answer",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RespondentResponse",
                table: "RespondentResponse",
                columns: new[] { "Id", "RespondentReferenceId", "SurveyReferenceId", "QuestionReferenceId", "AnswerReferenceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id");
        }
    }
}

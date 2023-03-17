using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Encuestas.Net.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class addIsMultiple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMultiple",
                table: "Question",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMultiple",
                table: "Question");
        }
    }
}

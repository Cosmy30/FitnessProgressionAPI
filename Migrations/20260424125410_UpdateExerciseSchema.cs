using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessProgressionAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateExerciseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Exercises",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Exercises");
        }
    }
}

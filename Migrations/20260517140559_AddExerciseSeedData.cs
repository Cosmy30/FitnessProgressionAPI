using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessProgressionAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddExerciseSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Category", "DifficultyLevel", "Family", "Name" },
                values: new object[,]
                {
                    { 1, 1, 2, "Vertical Pull", "Pull-up" },
                    { 2, 2, 3, "Vertical Pull", "Weighted Pull-up" },
                    { 3, 2, 1, "Vertical Pull", "Pull-down" },
                    { 4, 2, 1, "Horizontal Pull", "Cable Row" },
                    { 5, 1, 1, "Horizontal Pull", "Inverted Row" },
                    { 6, 2, 2, "Horizontal Pull", "Barbell Row" },
                    { 7, 1, 1, "Horizontal Push", "Push-up" },
                    { 8, 1, 2, "Horizontal Push", "Dip" },
                    { 9, 2, 2, "Horizontal Push", "Bench Press" },
                    { 10, 2, 2, "Vertical Push", "Overhead Press" },
                    { 11, 1, 2, "Vertical Push", "Pike Push-up" },
                    { 12, 1, 3, "Vertical Push", "Handstand Push-up" },
                    { 13, 1, 1, "Squat", "Squat" },
                    { 14, 2, 2, "Squat", "Weighted Squat" },
                    { 15, 1, 3, "Squat", "Pistol Squat" },
                    { 16, 2, 2, "Hinge", "Deadlift" },
                    { 17, 1, 2, "Core Flexion", "Leg Raise" },
                    { 18, 1, 3, "Core Static Hold", "Dragon Flag" },
                    { 19, 1, 2, "Core Static Hold", "L-Sit" },
                    { 20, 2, 2, "Core Flexion", "Weighted Cable Crunch" },
                    { 21, 1, 2, "Core Rotation", "Russian Twist" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}

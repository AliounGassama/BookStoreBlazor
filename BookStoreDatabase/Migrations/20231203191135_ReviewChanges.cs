using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ReviewChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookId", "GenreName" },
                values: new object[] { 15, null, "Self-Help" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 15);
        }
    }
}

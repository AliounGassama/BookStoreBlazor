using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreTable_GenreBookRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                    table.ForeignKey(
                        name: "FK_Genres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId");
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "BookId", "GenreName" },
                values: new object[,]
                {
                    { 1, null, "Fiction" },
                    { 2, null, "Nonfiction" },
                    { 3, null, "Mystery" },
                    { 4, null, "Thriller" },
                    { 5, null, "Romance" },
                    { 6, null, "Psychology" },
                    { 7, null, "Fantasy" },
                    { 8, null, "History" },
                    { 9, null, "Humor" },
                    { 10, null, "Graphic Novel" },
                    { 11, null, "Young Adult" },
                    { 12, null, "Science Fiction" },
                    { 13, null, "History" },
                    { 14, null, "Drama" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BookId",
                table: "Genres",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}

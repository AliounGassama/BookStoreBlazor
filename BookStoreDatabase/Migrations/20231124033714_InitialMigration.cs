using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreDatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    BookPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReviewDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartLineItems",
                columns: table => new
                {
                    CartLineItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLineItems", x => x.CartLineItemId);
                    table.ForeignKey(
                        name: "FK_CartLineItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartLineItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "BookPrice", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Robert Greene", 17f, "The 48 Laws of Power by Robert Greene is a self-help book offering advice on how to gain and maintain power, using lessons drawn from parables and the experiences of historical figures.\r\n\r\nPower depends on the relationships between a person and those he or she seeks to control. Powerful people must cultivate their appearances to earn respect and eliminate doubt. They must practice selective honesty, misdirection, and an excess of secrecy to gain a tactical advantage. Timing is central to maintaining power, as is the ability to adapt. The array of strategies available when seeking power include mirroring the opponent's actions and controlling the opponent's options for action. The powerful must also cultivate a relationship with audiences by creating spectacles and feeding their need to believe in the impossible.", "The 48 Laws of Power" },
                    { 2, "Sun Tzu", 16f, "The Art of War is a book of conflict knowledge and tactics revolving around several key concepts, including: Knowing when to fight and when not to fight. Knowing how to mislead the enemy. Knowing oneself and one's enemy.", "The Art of War" },
                    { 3, "Mark Manson", 15f, "In a nutshell, your values determine how you define success and failure, how you judge/measure yourself and others, and thus what you do and don’t do. Mark Manson’s core message in this book is this: to have a good life, you should only give a f*ck about the right values (which define your priorities). Don’t give a damn about anything else.", "The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life" },
                    { 4, "Jeff Kinney", 9f, "Up until now, middle school hasn't exactly been a joyride for Greg Heffley. So when the town threatens to close the crumbling building, he's not too broken up about it.\r\n\r\nBut when Greg realizes this means he's going to be sent to a different school than his best friend, Rowley Jefferson, he changes his tune. Can Greg and his classmates save their school before it's shuttered for good? Or is this the start of a whole new chapter for Greg?", "Diary of a Wimpy Kid: No Brainer" },
                    { 5, "Lincoln Peirce", 8f, "What's middle school without a crisis? Sixth-grader Nate Wright would love to find out, but the emergencies are piling up fast. A gang of eighth-graders steals Nate's favorite lunch spot. Alan Chen chooses a new name (hint: it begins with N) in a brazen attack on Nate's uniqueness. And when a post-hypnotic suggestion works a little TOO well, the lovable Chad becomes P.S. 38's unlikeliest bully. Is Nate any match for Bad Chad? Can he fly under the radar of no-nonsense hall monitor Kim Cressly? Will he survive the worst movie date ever with drama queen Dee Dee? Find out in Move It or Lose It! With all your favorite characters providing laughs on every page, this all-new collection of Big Nate comics means business!", "Big Nate: Move It or Lose It!" },
                    { 6, "John Marrs", 6f, "Mia and Finn are busy turning a derelict house into their dream home when Mia unexpectedly falls pregnant. But just when they think the house is ready, Mia discovers a shocking message scored into a skirting board: I WILL SAVE THEM FROM THE ATTIC. Following the clue up into the eaves, the couple make a gruesome discovery: their home was once a real-life murder house, with the evidence still concealed within the four walls.\r\n\r\nIn the wake of their traumatic discovery, the baby arrives and Mia can’t shake her fixation with the monstrous crimes that happened right above them. Tormented by the terrible things she saw, she is desperate to dig into the past to find answers.\r\n\r\nSecrecy shrouds the mystery of the attic, but when shards of a dark truth start to emerge, Mia realises the danger is terrifyingly present. She is prepared to do anything to protect her family―but will the previous tenants stop her from discovering their secret?", "Keep It In The Family" },
                    { 7, "John Hunt", 5f, "From bestselling thriller and horror author, John Hunt, comes a heart-pounding story of survival, grief, and redemption. Graham Richards, the sole survivor of a deadly shooting, has retreated to a remote cabin in the woods to escape the pain of his past. Living off the grid, he grows his own food and uses solar power for his energy needs, hoping to spend the rest of his life in obscurity.\r\n\r\nHowever, Graham's desire for solitude is shattered when a little girl goes missing in the nearby town, and the scarred man in the lonely cabin becomes the prime suspect. Graham finds himself pulled back into the world he wanted to leave behind, using his survival skills and instincts honed from years in the wilderness to clear his name and find the missing girl. But as he delves deeper into the case, he realizes that the threat is far greater than he ever imagined.\r\n\r\nWith gripping suspense and emotional intensity, this must-read thriller takes readers on a journey of heart-stopping danger and unexpected twists. Will Graham be able to confront his demons and save the missing girl before it's too late? Fans of intense psychological thrillers won't want to miss this haunting tale of one man's fight for redemption.", "Off The Grid" },
                    { 8, "Amal El-Mohtar; Max Gladstone", 18f, "Red and Blue are change agents who work for rival time traveling agencies–Blue for the Garden, a vast organic consciousness. Red works for the Agency, a Technotopia. While traveling to different “strands” of history and time to change history, they start to write each other letters and slowly fall in love.", "This is How You Lose the Time War" },
                    { 9, "Colleen Hoover", 15f, "After serving five years in prison for a tragic mistake, Kenna Rowan returns to the town where it all went wrong, hoping to reunite with her four-year-old daughter. But the bridges Kenna burned are proving impossible to rebuild. Everyone in her daughter’s life is determined to shut Kenna out, no matter how hard she works to prove herself.\r\n\r\nThe only person who hasn’t closed the door on her completely is Ledger Ward, a local bar owner and one of the few remaining links to Kenna’s daughter. But if anyone were to discover how Ledger is slowly becoming an important part of Kenna’s life, both would risk losing the trust of everyone important to them.\r\n\r\nThe two form a connection despite the pressure surrounding them, but as their romance grows, so does the risk. Kenna must find a way to absolve the mistakes of her past in order to build a future out of hope and healing.", "Reminders of Him" },
                    { 10, "D.H. Lawrence", 3f, "Lyric and sensual, D.H. Lawrence’s last novel is one of the major works of fiction of the twentieth century. Filled with scenes of intimate beauty, it explores the emotions of a lonely woman trapped in a sterile marriage and her growing love for the robust gamekeeper of her husband’s estate. The most controversial of Lawrence’s books, Lady Chatterly’s Lover joyously affirms the author’s vision of individual regeneration through sexual love. The book’s power, complexity, and psychological intricacy make this a completely original work—a triumph of passion, and a celebration of life.", "Lady Chatterley's Lover" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLineItems_BookId",
                table: "CartLineItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLineItems_CartId",
                table: "CartLineItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerId",
                table: "Carts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLineItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}

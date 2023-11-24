using BookStoreDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLineItem> CartLines { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = 1, GenreName = "Fiction" },

                new Genre { GenreId = 2, GenreName = "Nonfiction" },

                new Genre { GenreId = 3, GenreName = "Mystery" },

                new Genre { GenreId = 4, GenreName = "Thriller" },

                new Genre { GenreId = 5, GenreName = "Romance" },

                new Genre { GenreId = 6, GenreName = "Psychology" },

                new Genre { GenreId = 7, GenreName = "Fantasy" },

                new Genre { GenreId = 8, GenreName = "History" },

                new Genre { GenreId = 9, GenreName = "Humor" },

                new Genre { GenreId = 10, GenreName = "Graphic Novel" },

                new Genre { GenreId = 11, GenreName = "Young Adult" },

                new Genre { GenreId = 12, GenreName = "Science Fiction" },

                new Genre { GenreId = 13, GenreName = "History" },

                new Genre { GenreId = 14, GenreName = "Drama" },

                new Genre { GenreId = 15, GenreName = "Self-Help"}
                );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The 48 Laws of Power",
                    Description = "The 48 Laws of Power by Robert Greene " +
                "is a self-help book offering advice on how to gain and maintain power, using lessons drawn from parables and the experiences of historical figures." +
                "\r\n\r\nPower depends on the relationships between a person and those he or she seeks to control. Powerful people must cultivate their appearances to " +
                "earn respect and eliminate doubt. They must practice selective honesty, misdirection, and an excess of secrecy to gain a tactical advantage. Timing is " +
                "central to maintaining power, as is the ability to adapt. The array of strategies available when seeking power include mirroring the opponent's actions " +
                "and controlling the opponent's options for action. The powerful must also cultivate a relationship with audiences by creating spectacles and feeding " +
                "their need to believe in the impossible.",
                    Author = "Robert Greene",
                    BookPrice = 17f
                },

                new Book
                {
                    BookId = 2,
                    Title = "The Art of War",
                    Description = "The Art of War is a book of conflict knowledge and tactics revolving around several" +
                " key concepts, including: Knowing when to fight and when not to fight. Knowing how to mislead the enemy. Knowing oneself and one's enemy.",
                    Author = "Sun Tzu",
                    BookPrice = 16f
                },

                new Book
                {
                    BookId = 3,
                    Title = "The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life",
                    Description = "In a nutshell," +
                " your values determine how you define success and failure, how you judge/measure yourself and others, and thus what you do and don’t do. " +
                "Mark Manson’s core message in this book is this: to have a good life, you should only give a f*ck about the right values (which define your priorities). " +
                "Don’t give a damn about anything else.",
                    Author = "Mark Manson",
                    BookPrice = 15f
                },

                new Book
                {
                    BookId = 4,
                    Title = "Diary of a Wimpy Kid: No Brainer",
                    Description = "Up until now, middle school hasn't exactly been a joyride for Greg Heffley." +
                " So when the town threatens to close the crumbling building, he's not too broken up about it.\r\n\r\nBut when Greg realizes this means he's going to be " +
                "sent to a different school than his best friend, Rowley Jefferson, he changes his tune. Can Greg and his classmates save their school before it's shuttered" +
                " for good? Or is this the start of a whole new chapter for Greg?",
                    Author = "Jeff Kinney",
                    BookPrice = 9f
                },

                new Book
                {
                    BookId = 5,
                    Title = "Big Nate: Move It or Lose It!",
                    Description = "What's middle school without a crisis? Sixth-grader Nate Wright would love " +
                "to find out, but the emergencies are piling up fast. A gang of eighth-graders steals Nate's favorite lunch spot. Alan Chen chooses a new name " +
                "(hint: it begins with N) in a brazen attack on Nate's uniqueness. And when a post-hypnotic suggestion works a little TOO well, the lovable Chad becomes " +
                "P.S. 38's unlikeliest bully. Is Nate any match for Bad Chad? Can he fly under the radar of no-nonsense hall monitor Kim Cressly? Will he survive the" +
                " worst movie date ever with drama queen Dee Dee? Find out in Move It or Lose It! With all your favorite characters providing laughs on every page, " +
                "this all-new collection of Big Nate comics means business!",
                    Author = "Lincoln Peirce",
                    BookPrice = 8f
                },

                new Book
                {
                    BookId = 6,
                    Title = "Keep It In The Family",
                    Description = "Mia and Finn are busy turning a derelict house into their dream home when Mia " +
                "unexpectedly falls pregnant. But just when they think the house is ready, Mia discovers a shocking message scored into a skirting board: " +
                "I WILL SAVE THEM FROM THE ATTIC. Following the clue up into the eaves, the couple make a gruesome discovery: their home was once a real-life " +
                "murder house, with the evidence still concealed within the four walls.\r\n\r\nIn the wake of their traumatic discovery, the baby arrives and Mia " +
                "can’t shake her fixation with the monstrous crimes that happened right above them. Tormented by the terrible things she saw, she is desperate to dig " +
                "into the past to find answers.\r\n\r\nSecrecy shrouds the mystery of the attic, but when shards of a dark truth start to emerge, Mia realises the danger" +
                " is terrifyingly present. She is prepared to do anything to protect her family―but will the previous tenants stop her from discovering their secret?",
                    Author = "John Marrs",
                    BookPrice = 6f
                },

                new Book
                {
                    BookId = 7,
                    Title = "Off The Grid",
                    Description = "From bestselling thriller and horror author, John Hunt, comes a " +
                "heart-pounding story of survival, grief, and redemption. Graham Richards, the sole survivor of a deadly shooting, has retreated to a " +
                "remote cabin in the woods to escape the pain of his past. Living off the grid, he grows his own food and uses solar power for his energy needs," +
                " hoping to spend the rest of his life in obscurity.\r\n\r\nHowever, Graham's desire for solitude is shattered when a little girl goes missing" +
                " in the nearby town, and the scarred man in the lonely cabin becomes the prime suspect. Graham finds himself pulled back into the world he wanted" +
                " to leave behind, using his survival skills and instincts honed from years in the wilderness to clear his name and find the missing girl. But as" +
                " he delves deeper into the case, he realizes that the threat is far greater than he ever imagined.\r\n\r\nWith gripping suspense and emotional " +
                "intensity, this must-read thriller takes readers on a journey of heart-stopping danger and unexpected twists. Will Graham be able to confront " +
                "his demons and save the missing girl before it's too late? Fans of intense psychological thrillers won't want to miss this haunting tale of " +
                "one man's fight for redemption.",
                    Author = "John Hunt",
                    BookPrice = 5f
                },

                new Book
                {
                    BookId = 8,
                    Title = "This is How You Lose the Time War",
                    Description = "Red and Blue are change agents who work for rival time traveling" +
                " agencies–Blue for the Garden, a vast organic consciousness. Red works for the Agency, a Technotopia. " +
                "While traveling to different “strands” of history and time to change history, they start to write each other letters and slowly fall in love.",
                    Author = "Amal El-Mohtar; Max Gladstone",
                    BookPrice = 18f
                },

                new Book
                {
                    BookId = 9,
                    Title = "Reminders of Him",
                    Description = "After serving five years in prison for a tragic mistake," +
                " Kenna Rowan returns to the town where it all went wrong, hoping to reunite with her four-year-old daughter. But the bridges " +
                "Kenna burned are proving impossible to rebuild. Everyone in her daughter’s life is determined to shut Kenna out, no matter how hard" +
                " she works to prove herself.\r\n\r\nThe only person who hasn’t closed the door on her completely is Ledger Ward, a local bar owner " +
                "and one of the few remaining links to Kenna’s daughter. But if anyone were to discover how Ledger is slowly becoming an important part" +
                " of Kenna’s life, both would risk losing the trust of everyone important to them.\r\n\r\nThe two form a connection despite the pressure" +
                " surrounding them, but as their romance grows, so does the risk. Kenna must find a way to absolve the mistakes of her past in order " +
                "to build a future out of hope and healing.",
                    Author = "Colleen Hoover",
                    BookPrice = 15f
                },

                new Book
                {
                    BookId = 10,
                    Title = "Lady Chatterley's Lover",
                    Description = "Lyric and sensual, D.H. Lawrence’s last novel is one of " +
                "the major works of fiction of the twentieth century. Filled with scenes of intimate beauty, it explores the emotions of a lonely" +
                " woman trapped in a sterile marriage and her growing love for the robust gamekeeper of her husband’s estate. The most controversial" +
                " of Lawrence’s books, Lady Chatterly’s Lover joyously affirms the author’s vision of individual regeneration through sexual love. " +
                "The book’s power, complexity, and psychological intricacy make this a completely original work—a triumph of passion, and a celebration" +
                " of life.",
                    Author = "D.H. Lawrence",
                    BookPrice = 3f
                }
                );
        }
    }
}
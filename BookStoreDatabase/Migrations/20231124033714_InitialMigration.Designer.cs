﻿// <auto-generated />
using System;
using BookStoreDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStoreDatabase.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    [Migration("20231124033714_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStoreWebApi.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<float>("BookPrice")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "Robert Greene",
                            BookPrice = 17f,
                            Description = "The 48 Laws of Power by Robert Greene is a self-help book offering advice on how to gain and maintain power, using lessons drawn from parables and the experiences of historical figures.\r\n\r\nPower depends on the relationships between a person and those he or she seeks to control. Powerful people must cultivate their appearances to earn respect and eliminate doubt. They must practice selective honesty, misdirection, and an excess of secrecy to gain a tactical advantage. Timing is central to maintaining power, as is the ability to adapt. The array of strategies available when seeking power include mirroring the opponent's actions and controlling the opponent's options for action. The powerful must also cultivate a relationship with audiences by creating spectacles and feeding their need to believe in the impossible.",
                            Title = "The 48 Laws of Power"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "Sun Tzu",
                            BookPrice = 16f,
                            Description = "The Art of War is a book of conflict knowledge and tactics revolving around several key concepts, including: Knowing when to fight and when not to fight. Knowing how to mislead the enemy. Knowing oneself and one's enemy.",
                            Title = "The Art of War"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "Mark Manson",
                            BookPrice = 15f,
                            Description = "In a nutshell, your values determine how you define success and failure, how you judge/measure yourself and others, and thus what you do and don’t do. Mark Manson’s core message in this book is this: to have a good life, you should only give a f*ck about the right values (which define your priorities). Don’t give a damn about anything else.",
                            Title = "The Subtle Art of Not Giving a F*ck: A Counterintuitive Approach to Living a Good Life"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "Jeff Kinney",
                            BookPrice = 9f,
                            Description = "Up until now, middle school hasn't exactly been a joyride for Greg Heffley. So when the town threatens to close the crumbling building, he's not too broken up about it.\r\n\r\nBut when Greg realizes this means he's going to be sent to a different school than his best friend, Rowley Jefferson, he changes his tune. Can Greg and his classmates save their school before it's shuttered for good? Or is this the start of a whole new chapter for Greg?",
                            Title = "Diary of a Wimpy Kid: No Brainer"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "Lincoln Peirce",
                            BookPrice = 8f,
                            Description = "What's middle school without a crisis? Sixth-grader Nate Wright would love to find out, but the emergencies are piling up fast. A gang of eighth-graders steals Nate's favorite lunch spot. Alan Chen chooses a new name (hint: it begins with N) in a brazen attack on Nate's uniqueness. And when a post-hypnotic suggestion works a little TOO well, the lovable Chad becomes P.S. 38's unlikeliest bully. Is Nate any match for Bad Chad? Can he fly under the radar of no-nonsense hall monitor Kim Cressly? Will he survive the worst movie date ever with drama queen Dee Dee? Find out in Move It or Lose It! With all your favorite characters providing laughs on every page, this all-new collection of Big Nate comics means business!",
                            Title = "Big Nate: Move It or Lose It!"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "John Marrs",
                            BookPrice = 6f,
                            Description = "Mia and Finn are busy turning a derelict house into their dream home when Mia unexpectedly falls pregnant. But just when they think the house is ready, Mia discovers a shocking message scored into a skirting board: I WILL SAVE THEM FROM THE ATTIC. Following the clue up into the eaves, the couple make a gruesome discovery: their home was once a real-life murder house, with the evidence still concealed within the four walls.\r\n\r\nIn the wake of their traumatic discovery, the baby arrives and Mia can’t shake her fixation with the monstrous crimes that happened right above them. Tormented by the terrible things she saw, she is desperate to dig into the past to find answers.\r\n\r\nSecrecy shrouds the mystery of the attic, but when shards of a dark truth start to emerge, Mia realises the danger is terrifyingly present. She is prepared to do anything to protect her family―but will the previous tenants stop her from discovering their secret?",
                            Title = "Keep It In The Family"
                        },
                        new
                        {
                            BookId = 7,
                            Author = "John Hunt",
                            BookPrice = 5f,
                            Description = "From bestselling thriller and horror author, John Hunt, comes a heart-pounding story of survival, grief, and redemption. Graham Richards, the sole survivor of a deadly shooting, has retreated to a remote cabin in the woods to escape the pain of his past. Living off the grid, he grows his own food and uses solar power for his energy needs, hoping to spend the rest of his life in obscurity.\r\n\r\nHowever, Graham's desire for solitude is shattered when a little girl goes missing in the nearby town, and the scarred man in the lonely cabin becomes the prime suspect. Graham finds himself pulled back into the world he wanted to leave behind, using his survival skills and instincts honed from years in the wilderness to clear his name and find the missing girl. But as he delves deeper into the case, he realizes that the threat is far greater than he ever imagined.\r\n\r\nWith gripping suspense and emotional intensity, this must-read thriller takes readers on a journey of heart-stopping danger and unexpected twists. Will Graham be able to confront his demons and save the missing girl before it's too late? Fans of intense psychological thrillers won't want to miss this haunting tale of one man's fight for redemption.",
                            Title = "Off The Grid"
                        },
                        new
                        {
                            BookId = 8,
                            Author = "Amal El-Mohtar; Max Gladstone",
                            BookPrice = 18f,
                            Description = "Red and Blue are change agents who work for rival time traveling agencies–Blue for the Garden, a vast organic consciousness. Red works for the Agency, a Technotopia. While traveling to different “strands” of history and time to change history, they start to write each other letters and slowly fall in love.",
                            Title = "This is How You Lose the Time War"
                        },
                        new
                        {
                            BookId = 9,
                            Author = "Colleen Hoover",
                            BookPrice = 15f,
                            Description = "After serving five years in prison for a tragic mistake, Kenna Rowan returns to the town where it all went wrong, hoping to reunite with her four-year-old daughter. But the bridges Kenna burned are proving impossible to rebuild. Everyone in her daughter’s life is determined to shut Kenna out, no matter how hard she works to prove herself.\r\n\r\nThe only person who hasn’t closed the door on her completely is Ledger Ward, a local bar owner and one of the few remaining links to Kenna’s daughter. But if anyone were to discover how Ledger is slowly becoming an important part of Kenna’s life, both would risk losing the trust of everyone important to them.\r\n\r\nThe two form a connection despite the pressure surrounding them, but as their romance grows, so does the risk. Kenna must find a way to absolve the mistakes of her past in order to build a future out of hope and healing.",
                            Title = "Reminders of Him"
                        },
                        new
                        {
                            BookId = 10,
                            Author = "D.H. Lawrence",
                            BookPrice = 3f,
                            Description = "Lyric and sensual, D.H. Lawrence’s last novel is one of the major works of fiction of the twentieth century. Filled with scenes of intimate beauty, it explores the emotions of a lonely woman trapped in a sterile marriage and her growing love for the robust gamekeeper of her husband’s estate. The most controversial of Lawrence’s books, Lady Chatterly’s Lover joyously affirms the author’s vision of individual regeneration through sexual love. The book’s power, complexity, and psychological intricacy make this a completely original work—a triumph of passion, and a celebration of life.",
                            Title = "Lady Chatterley's Lover"
                        });
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<DateTime>("CartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.CartLineItem", b =>
                {
                    b.Property<int>("CartLineItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartLineItemId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartLineItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("CartId");

                    b.ToTable("CartLineItems");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewTitle")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Cart", b =>
                {
                    b.HasOne("BookStoreWebApi.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.CartLineItem", b =>
                {
                    b.HasOne("BookStoreWebApi.Entities.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreWebApi.Entities.Cart", null)
                        .WithMany("LineItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Review", b =>
                {
                    b.HasOne("BookStoreWebApi.Entities.Book", null)
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStoreWebApi.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BookStoreWebApi.Entities.Cart", b =>
                {
                    b.Navigation("LineItems");
                });
#pragma warning restore 612, 618
        }
    }
}

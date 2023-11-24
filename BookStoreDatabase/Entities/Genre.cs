using System.ComponentModel.DataAnnotations.Schema;

namespace BookStoreDatabase.Entities
{

    [Table("Genres")]
    public class Genre
    {
        public int GenreId { get; set; }

        public string? GenreName { get; set; }
    }
}

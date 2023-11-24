using BookStoreDatabase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [MaxLength(70)]
        public string? Author { get; set; }

        public float BookPrice { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    }
}

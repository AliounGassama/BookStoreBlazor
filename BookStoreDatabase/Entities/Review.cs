using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }

        [MaxLength(100)]
        public string? ReviewTitle { get; set; }

        public string? ReviewDescription { get; set; }

        [Range(1,5)]
        public int ReviewRating { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        public Book? Book { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }
    }
}
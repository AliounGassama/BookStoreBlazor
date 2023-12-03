using BookStoreDatabase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels
{
    public class ReviewViewModel
    {
        [Required]
        [MaxLength(100)]
        public string? ReviewTitle { get; set; }

        [Required]
        public string? ReviewDescription { get; set; }

        [Required]
        [Range(1,5)]
        public int ReviewRating { get; set; }

        public int BookId { get; set; }

        public int CustomerId { get; set; }
    }
}

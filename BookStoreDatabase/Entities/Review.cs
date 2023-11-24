﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        public int ReviewRating { get; set; }

        public int BookId { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }
    }
}
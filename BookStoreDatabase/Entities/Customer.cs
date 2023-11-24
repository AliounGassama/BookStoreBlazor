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
    [Table("Customers")]
    public class Customer
    {
        public int CustomerId { get; set; }

        [DisplayName("First Name")]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(50)]
        public string? Address { get; set; }

        [MaxLength(90)]
        public string? City { get; set; }

        [MaxLength(50)]
        public string? State { get; set; }

        [DisplayName("Zip Code")]
        [MaxLength(50)]
        public string? PostalCode { get; set; }
    }
}
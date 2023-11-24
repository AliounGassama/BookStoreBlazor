using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }

        [DisplayName("First Name")]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [MaxLength(50)]
        [DisplayName("Customer Name")]
        public string FullName => $"  {LastName}, {FirstName}";

        public string? Address { get; set; }

        [MaxLength(50)]
        public string? City { get; set; }

        [MaxLength(50)]
        public string? State { get; set; }

        [DisplayName("Zip Code")]
        [MaxLength(50)]
        public string? PostalCode { get; set; }
    }
}

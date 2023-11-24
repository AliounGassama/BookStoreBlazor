using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase.Entities
{
    [Table("CartLineItems")]
    public class CartLineItem
    {
        public int CartLineItemId { get; set; }

        public int CartId { get; set; }

        public int BookId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public virtual Book? Book { get; set; } = null;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase.Entities
{
    [Table("Carts")]
    public class Cart
    {
        public int CartId { get; set; }

        public DateTime CartDate { get; set; }

        public virtual Customer? Customer { get; set; } = null;

        public virtual ICollection<CartLineItem> CartLineItems { get; set; } = new List<CartLineItem>();
    }
}
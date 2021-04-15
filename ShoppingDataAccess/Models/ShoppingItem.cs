using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDataAccessLayer.Models
{
    public class ShoppingItem
    {
        public long ShoppingItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public virtual ShoppingOccasion Occasion { get; set; }
        public virtual ShoppingPlace Place { get; set; }
    }
}

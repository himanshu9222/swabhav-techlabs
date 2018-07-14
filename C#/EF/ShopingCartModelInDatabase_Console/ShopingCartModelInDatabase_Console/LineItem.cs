using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartModelInDatabase_Console
{
    public class LineItem
    {
        [Key]
        public int LineItemId { get; set; }
        public Product P { get; set; }
        public Order O { get; set; }
        public int Quantity { get; set; }

        public LineItem()
        {
            
        }
    }
}

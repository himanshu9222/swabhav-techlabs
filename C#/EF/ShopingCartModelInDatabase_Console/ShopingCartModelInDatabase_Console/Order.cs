using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartModelInDatabase_Console
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }
        public Customer C { get; set; }
        public DateTime Orderdate { get; set; }
        public double CheckoutPrice { get; set; }
        public List<LineItem> LineItemList { get; set; }

        public Order()
        {
            LineItemList = new List<LineItem>();
        }
    }
}

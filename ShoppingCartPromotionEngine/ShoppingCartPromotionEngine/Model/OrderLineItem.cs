using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine.Model
{
    public class OrderLineItem
    {
        public int OrderLineItemId { get; set; }
        public string SKUId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

    }
}

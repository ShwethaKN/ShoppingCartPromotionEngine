using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine.Model
{
    public class CartDTO
    {
        public int CartId { get; set; }
        public int OrderId { get; set; }

        public List<CartItemsDTO> CartItems { get; set; }
    }
    public class CartItemsDTO
    {
        public int OrderLineItemId { get; set; }
        public string SKUId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}

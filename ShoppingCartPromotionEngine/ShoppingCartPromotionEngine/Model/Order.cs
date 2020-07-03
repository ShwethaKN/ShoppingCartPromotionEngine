using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int OrderLineId { get; set; }

        public string BillingAddress { get; set; }

        public decimal BillAmount { get; set; }

        public DateTime OrderPlacementDate { get; set; }

        public DateTime OrderDeliveryDate { get; set; }
    }
}

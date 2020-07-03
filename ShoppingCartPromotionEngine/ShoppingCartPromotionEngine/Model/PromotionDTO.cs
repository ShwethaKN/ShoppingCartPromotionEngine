using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine.Model
{
    public class PromotionDTO
    {
        public int PromotionId { get; set; }
        public string PromotionCode { get; set; }

        public bool CodeStatus { get; set; }
    }
}

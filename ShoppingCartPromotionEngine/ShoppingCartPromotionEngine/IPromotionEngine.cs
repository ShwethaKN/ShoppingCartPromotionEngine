using ShoppingCartPromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine
{
    public interface IPromotionEngine
    {
        decimal ApplyPromotionCode(List<CartItemsDTO> cartItemsModelObj, List<PromotionDTO> promotionCodes);
        List<PromotionDTO> GetActivePromotionCode();
       
    }
}

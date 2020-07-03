using ShoppingCartPromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine
{
    public class ShoppingCart
    {
        readonly IPromotionEngine promotionObj;
        //private CartDTO cartViewModelObj = null;

        public ShoppingCart(IPromotionEngine promotionObj)
        {
            this.promotionObj = promotionObj;
        }
        public decimal CheckoutCart(CartDTO cartViewModelObj)
        {
            decimal totalBillAmount = 0;
            if(cartViewModelObj != null && cartViewModelObj.CartItems != null && cartViewModelObj.CartItems.Count > 0)
            {
                var promotionCodes = promotionObj.GetActivePromotionCode();
                totalBillAmount = promotionObj.ApplyPromotionCode(cartViewModelObj.CartItems, promotionCodes);
            }
            return totalBillAmount;
        }        
    }
}

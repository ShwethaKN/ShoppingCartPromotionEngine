using ShoppingCartPromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine
{
    public static class CartData
    {
        //data where promotion is not applicable
        public static CartDTO PrepareNoPromotionData()
        {
            CartItemsDTO cartItemsViewModelObj;
            CartDTO cartViewModelObj = new CartDTO();
            cartViewModelObj.CartId = 1;
            cartViewModelObj.OrderId = 1;
            cartViewModelObj.CartItems = new List<CartItemsDTO>();
            //item 1
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 1;
            cartItemsViewModelObj.SKUId = "A";
            cartItemsViewModelObj.ProductName = "Almonds";
            cartItemsViewModelObj.ProductDescription = "California''s handpicked almonds.Best quality.";
            cartItemsViewModelObj.UnitPrice = 50;
            cartItemsViewModelObj.Quantity = 1;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 2
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 2;
            cartItemsViewModelObj.SKUId = "B";
            cartItemsViewModelObj.ProductName = "Cashews";
            cartItemsViewModelObj.ProductDescription = "Cashews with best quality assured.";
            cartItemsViewModelObj.UnitPrice = 30;
            cartItemsViewModelObj.Quantity = 1;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 3
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 3;
            cartItemsViewModelObj.SKUId = "C";
            cartItemsViewModelObj.ProductName = "Walnuts";
            cartItemsViewModelObj.ProductDescription = "Walnuts with no bitter taste.";
            cartItemsViewModelObj.UnitPrice = 20;
            cartItemsViewModelObj.Quantity = 1;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);

            return cartViewModelObj;
        }

        //data where promotion is applicable
        public static CartDTO PreparePromotionData()
        {
            CartItemsDTO cartItemsViewModelObj;
            CartDTO cartViewModelObj = new CartDTO();
            cartViewModelObj.CartId = 2;
            cartViewModelObj.OrderId = 2;
            cartViewModelObj.CartItems = new List<CartItemsDTO>();
            //item 1
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 1;
            cartItemsViewModelObj.SKUId = "A";
            cartItemsViewModelObj.ProductName = "Almonds";
            cartItemsViewModelObj.ProductDescription = "California''s handpicked almonds.Best quality.";
            cartItemsViewModelObj.UnitPrice = 50;
            cartItemsViewModelObj.Quantity = 5;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 2
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 2;
            cartItemsViewModelObj.SKUId = "B";
            cartItemsViewModelObj.ProductName = "Cashews";
            cartItemsViewModelObj.ProductDescription = "Cashews with best quality assured.";
            cartItemsViewModelObj.UnitPrice = 30;
            cartItemsViewModelObj.Quantity = 5;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 3
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 3;
            cartItemsViewModelObj.SKUId = "C";
            cartItemsViewModelObj.ProductName = "Walnuts";
            cartItemsViewModelObj.ProductDescription = "Walnuts with no bitter taste.";
            cartItemsViewModelObj.UnitPrice = 20;
            cartItemsViewModelObj.Quantity = 1;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);

            return cartViewModelObj;
        }

        public static CartDTO PreparePromotionData2()
        {
            CartItemsDTO cartItemsViewModelObj;
            CartDTO cartViewModelObj = new CartDTO();
            cartViewModelObj.CartId = 2;
            cartViewModelObj.OrderId = 2;
            cartViewModelObj.CartItems = new List<CartItemsDTO>();
            //item 1
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 1;
            cartItemsViewModelObj.SKUId = "A";
            cartItemsViewModelObj.ProductName = "Almonds";
            cartItemsViewModelObj.ProductDescription = "California''s handpicked almonds.Best quality.";
            cartItemsViewModelObj.UnitPrice = 50;
            cartItemsViewModelObj.Quantity = 3;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 2
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 2;
            cartItemsViewModelObj.SKUId = "B";
            cartItemsViewModelObj.ProductName = "Cashews";
            cartItemsViewModelObj.ProductDescription = "Cashews with best quality assured.";
            cartItemsViewModelObj.UnitPrice = 30;
            cartItemsViewModelObj.Quantity = 5;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 3
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 3;
            cartItemsViewModelObj.SKUId = "C";
            cartItemsViewModelObj.ProductName = "Walnuts";
            cartItemsViewModelObj.ProductDescription = "Walnuts with no bitter taste.";
            cartItemsViewModelObj.UnitPrice = 20;
            cartItemsViewModelObj.Quantity = 1;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);
            //item 4
            cartItemsViewModelObj = new CartItemsDTO();
            cartItemsViewModelObj.OrderLineItemId = 4;
            cartItemsViewModelObj.SKUId = "D";
            cartItemsViewModelObj.ProductName = "Raisins";
            cartItemsViewModelObj.ProductDescription = "Soft and Sweet Raisins";
            cartItemsViewModelObj.UnitPrice = 15;
            cartItemsViewModelObj.Quantity = 1;
            cartViewModelObj.CartItems.Add(cartItemsViewModelObj);

            return cartViewModelObj;
        }

        public static List<PromotionDTO> PreparePromotionCodeData()
        {
            PromotionDTO promotionObj;
            List<PromotionDTO> promotionList = new List<PromotionDTO>();
            promotionObj = new PromotionDTO();
            promotionObj.PromotionId = 1;
            promotionObj.PromotionCode = "3 of A's for 130";
            promotionObj.CodeStatus = true;
            promotionList.Add(promotionObj);
            promotionObj = new PromotionDTO();
            promotionObj.PromotionId = 2;
            promotionObj.PromotionCode = "2 of B's for 45";
            promotionObj.CodeStatus = true;
            promotionList.Add(promotionObj);
            promotionObj = new PromotionDTO();
            promotionObj.PromotionId = 3;
            promotionObj.PromotionCode = "C & D for 30";
            promotionObj.CodeStatus = true;
            promotionList.Add(promotionObj);

            return promotionList;
        }
    }
}

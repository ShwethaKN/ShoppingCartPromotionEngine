using ShoppingCartPromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IPromotionEngine promotionObj = new PromotionEngine();
            ShoppingCart classObj = new ShoppingCart(promotionObj);
            //scenario A - PrepareNoPromotionData()
            //scenario B - PreparePromotionData()
            //scenario C - PreparePromotionData2()
            decimal totalBillAmount = classObj.CheckoutCart(CartData.PreparePromotionData2());
            Console.WriteLine("The Final bill amount after applying promotion code is : {0}", totalBillAmount);
            Console.ReadLine();
        }
        
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartPromotionEngine.Model;
using ShoppingCartPromotionEngine;
using System.Collections.Generic;

namespace ShoppingCartPromotionEngineTests
{
    [TestClass]
    public class PromotionEngineTest
    {
        PromotionEngine promotionEngineObj;
        [TestMethod]
        //scenation A - 1 * A = 50 ;1 * B = 30 ;1 * C = 20
        public void TestNoPromoCodeScenarioA()
        {
            decimal totalBillAmount = 0;
            promotionEngineObj = new PromotionEngine();
            var inputData = CartData.PrepareNoPromotionData();
            var promotionCodeData = CartData.PreparePromotionCodeData();
            totalBillAmount = promotionEngineObj.ApplyPromotionCode(inputData.CartItems, promotionCodeData);

            Assert.AreEqual(100, totalBillAmount);
        }

        [TestMethod]
        //scenation A - 5 * A = 130 + 2*50 ;5 * B = 45 + 45 + 30 ;1 * C = 20
        public void TestPromoCodeScenarioB()
        {
            decimal totalBillAmount = 0;
            promotionEngineObj = new PromotionEngine();
            var inputData = CartData.PreparePromotionData();
            var promotionCodeData = CartData.PreparePromotionCodeData();
            totalBillAmount = promotionEngineObj.ApplyPromotionCode(inputData.CartItems,promotionCodeData);

            Assert.AreEqual(370, totalBillAmount);
        }

        [TestMethod]
        //scenation A - 3 * A = 130 ;5 * B = 45 + 45 + 30 ;1 * C ;1 * D = 30
        public void TestPromoCodeScenarioC()
        {
            decimal totalBillAmount = 0;
            promotionEngineObj = new PromotionEngine();
            var inputData = CartData.PreparePromotionData2();
            var promotionCodeData = CartData.PreparePromotionCodeData();
            totalBillAmount = promotionEngineObj.ApplyPromotionCode(inputData.CartItems, promotionCodeData);

            Assert.AreEqual(280, totalBillAmount);
        }

       
    }
}

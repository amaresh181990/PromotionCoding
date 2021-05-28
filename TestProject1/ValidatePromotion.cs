using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionCoding.Core.Service;
using System;
using System.Collections.Generic;
using PromotionCoding.Models;
using System.Text;

namespace PromotionUnitTest
{
    [TestClass]
    public class ValidatePromotion
    {
        private PromotionService promotionService;
        public ValidatePromotion()
        {
            promotionService = new PromotionService();
        }
        [TestMethod]
        public void Validate_Promotion_TotalPrice_Scenario1_Success()
        {
            List<Product> Product = new List<Product>()
            {
                new Product() { SKUID = "A" , Price = 50,Qty = 1},
                new Product() { SKUID = "B" , Price = 30,Qty = 1},
                new Product() { SKUID = "C" , Price = 20,Qty = 1},
                new Product() { SKUID = "D" , Price = 15,Qty = 0}
            };


            int s = promotionService.GetTotalPrice(Product);
            Assert.AreEqual(100, s);
        }
        [TestMethod]
        public void Validate_Promotion_TotalPrice_Scenario2_Success()
        {
            List<Product> Product = new List<Product>()
            {
                new Product() { SKUID = "A" , Price = 50,Qty = 5},
                new Product() { SKUID = "B" , Price = 30,Qty = 5},
                new Product() { SKUID = "C" , Price = 20,Qty = 1},
                new Product() { SKUID = "D" , Price = 15,Qty = 0}
            };


            int s = promotionService.GetTotalPrice(Product);
            Assert.AreEqual(370, s);
        }
        [TestMethod]
        public void Validate_Promotion_TotalPrice_Scenario3_Success()
        {
            List<Product> Product = new List<Product>()
            {
                new Product() { SKUID = "A" , Price = 50,Qty = 3},
                new Product() { SKUID = "B" , Price = 30,Qty = 5},
                new Product() { SKUID = "C" , Price = 20,Qty = 1},
                new Product() { SKUID = "D" , Price = 15,Qty = 1}
            };


            int s = promotionService.GetTotalPrice(Product);
            Assert.AreEqual(280, s);
        }
    }
}

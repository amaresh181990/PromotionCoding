using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionCoding.Controllers;
using PromotionCoding.Core.Service;
using PromotionCoding.Infrastructure.Data;
using PromotionCoding.Models;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private StaticProductRepository staticProductRepository;
        private ProductDetailsService productDetailsService;
        private PromotionService promotionService;
        private ProductController productController;
        public UnitTest1()
        {
            staticProductRepository = new StaticProductRepository();
            productDetailsService = new ProductDetailsService(staticProductRepository);
            promotionService = new PromotionService();
            productController = new ProductController(productDetailsService, promotionService);
        }
        [TestMethod]
        public void Validate_TotalPrice_Scenario1_Success()
        {
            List<Product>  Product = new List<Product>()
            {
                new Product() { SKUID = "A" , Price = 50,Qty = 1},
                new Product() { SKUID = "B" , Price = 30,Qty = 1},
                new Product() { SKUID = "C" , Price = 20,Qty = 1},
                new Product() { SKUID = "D" , Price = 15,Qty = 0}
            };
            
            
            int s = productController.FetchTotalPrice(Product);
            Assert.AreEqual(100, s);
        }
        [TestMethod]
        public void Validate_TotalPrice_Scenario2_Success()
        {
            List<Product> Product = new List<Product>()
            {
                new Product() { SKUID = "A" , Price = 50,Qty = 5},
                new Product() { SKUID = "B" , Price = 30,Qty = 5},
                new Product() { SKUID = "C" , Price = 20,Qty = 1},
                new Product() { SKUID = "D" , Price = 15,Qty = 0}
            };


            int s = productController.FetchTotalPrice(Product);
            Assert.AreEqual(370, s);
        }
        

    }
}

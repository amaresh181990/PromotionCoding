using PromotionCoding.Core.Interfaces;
using PromotionCoding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionCoding.Infrastructure.Data
{
    public class StaticProductRepository : IProductDetailsRepository
    {
        private List<Product> Products;
        public StaticProductRepository()
        {
            Products = new List<Product>()
            {
                new Product() { SKUID = "A" , Price = 50,Qty = 0},
                new Product() { SKUID = "B" , Price = 30,Qty = 0},
                new Product() { SKUID = "C" , Price = 20,Qty = 0},
                new Product() { SKUID = "D" , Price = 15,Qty = 0}
            };
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}

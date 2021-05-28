using PromotionCoding.Core.Interfaces;
using PromotionCoding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionCoding.Core.Service
{
    public class ProductDetailsService : IProductservice
    {
        private IProductDetailsRepository _productDetailsRepository;

        public ProductDetailsService(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }

        public List<Product> GetProducts()
        {
           return  _productDetailsRepository.GetProducts();
        }
    }
}

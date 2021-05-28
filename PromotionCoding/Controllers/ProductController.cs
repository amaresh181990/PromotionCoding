using Microsoft.AspNetCore.Mvc;
using PromotionCoding.Core.Interfaces;
using PromotionCoding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionCoding.Controllers
{
    public class ProductController : Controller
    {
        
        private IProductservice _productservice;
        private IPromotionService _promotionService;

        public ProductController(IProductservice productservice, IPromotionService promotionService)
        {
            _productservice = productservice;
            _promotionService = promotionService;
        }
        public ViewResult Products()
        {
            return View(_productservice.GetProducts());
        }
        [HttpPost]
        public int FetchTotalPrice(List<Product> product)
        {


            return _promotionService.GetTotalPrice(product);
        }


    }
}

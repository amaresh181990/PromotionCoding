using Microsoft.AspNetCore.Mvc;
using PromotionCoding.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionCoding.Controllers
{
    public class ProductController : Controller
    {
        
        private IProductservice _productservice;

        public ProductController(IProductservice productservice)
        {
            _productservice = productservice;
        }
        public ViewResult Products()
        {
            return View(_productservice.GetProducts());
        }

        
    }
}

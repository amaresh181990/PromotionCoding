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
        private IProductDetailsRepository _productDetailsRepository;

        public ProductController(IProductDetailsRepository productDetailsRepository)
        {
            _productDetailsRepository = productDetailsRepository;
        }
        public ViewResult Products()
        {
            return View(_productDetailsRepository.GetProducts());
        }

        
    }
}

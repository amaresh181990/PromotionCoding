using PromotionCoding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionCoding.Core.Interfaces
{
    public interface IPromotionService
    {
        int GetTotalPrice(List<Product> productModel);
    }
}

using PromotionCoding.Core.Interfaces;
using PromotionCoding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionCoding.Core.Service
{
    public class PromotionService : IPromotionService
    {
        public int GetTotalPrice(List<Product> product)
        {
            int unitsA = Convert.ToInt32(product.Where(s => s.SKUID.Equals("A")).Select(n => n.Qty).FirstOrDefault());
            int unitsB = Convert.ToInt32(product.Where(s => s.SKUID == "B").Select(n => n.Qty).FirstOrDefault());
            int unitsC = Convert.ToInt32(product.Where(s => s.SKUID == "C").Select(n => n.Qty).FirstOrDefault());
            int unitsD = Convert.ToInt32(product.Where(s => s.SKUID == "D").Select(n => n.Qty).FirstOrDefault());
            int priceA = 0;
            int priceB = 0;
            //int priceC = 0, priceD = 0, priceCD = 0;

            if (unitsA > 0)
            {
                priceA = 130 * (unitsA / 3) + 50 * (unitsA % 3);
            }
            if (unitsB > 0)
            {
                priceB = 45 * (unitsB / 2) + 30 * (unitsB % 2);
            }
            //if (unitsC < unitsD)
            //{
            //    priceCD = unitsC * 30 + 2;
            //}
            return priceA + priceB;
        }
    }
}

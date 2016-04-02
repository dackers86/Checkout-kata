using LateRooms.CheckoutKata.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Domain.Models.Offers
{
    public class SpecialOffer : IDiscount
    {
        public void ApplyDiscounts(List<Item> items, ref Item item)
        {
            var sku = item.SKU;
            if (items.Where(x => x.SKU == sku).ToList().Count == 2)
            {
                item.UnitPrice = item.UnitPrice - 20;
            }
        }
    }
}

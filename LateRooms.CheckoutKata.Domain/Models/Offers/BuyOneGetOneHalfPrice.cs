using LateRooms.CheckoutKata.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Domain.Models.Offers
{
    public class BuyOneGetOneHalfPrice : IDiscount
    {
        public void ApplyDiscounts(List<Item> items, ref Item item)
        {
            var sku = item.SKU;
            if (items.Any(x => x.SKU == sku))
            {
                item.UnitPrice = item.UnitPrice / 2;
            }
        }
    }
}

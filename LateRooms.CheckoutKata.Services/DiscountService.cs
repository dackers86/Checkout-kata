using LateRooms.CheckoutKata.Domain.Interfaces;
using LateRooms.CheckoutKata.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Services
{
    public class DiscountService : IDiscountService
    {
        public Item ApplyDiscounts(List<Item> items, Item item)
        {
            if (item.SKU == "B" && items.Any(x => x.SKU == item.SKU))
            {
                item.UnitPrice = item.UnitPrice / 2;
            }

            if (item.SKU == "A" && items.Where(x => x.SKU == "A").ToList().Count == 2)
            {
                item.UnitPrice = item.UnitPrice - 20;
            }

            return item;
        }
    }       
}


using LateRooms.CheckoutKata.Domain.Interfaces;
using LateRooms.CheckoutKata.Domain.Models;
using LateRooms.CheckoutKata.Domain.Models.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Services
{
    public class DiscountService : IDiscountService
    {
        public void ApplyDiscounts(List<Item> items, Item item)
        {
            foreach(var discount in item.Discounts)
            {
                discount.ApplyDiscounts(items, ref item);
            }
        }
    }       
}


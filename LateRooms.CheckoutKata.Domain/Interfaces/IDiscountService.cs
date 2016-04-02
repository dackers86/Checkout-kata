using LateRooms.CheckoutKata.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Domain.Interfaces
{
    public interface IDiscountService
    {
        Item ApplyDiscounts(List<Item> items, Item item);
    }
}

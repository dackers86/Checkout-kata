using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Domain.Models.Interfaces
{
    public interface IDiscount
    {
        void ApplyDiscounts(List<Item> items, ref Item item);
    }
}

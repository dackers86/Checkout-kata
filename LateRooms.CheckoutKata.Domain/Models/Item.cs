using LateRooms.CheckoutKata.Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Domain.Models
{
    public class Item
    {
        public Item()
        {
            Discounts = new List<IDiscount>();
        }

        public string SKU { get; set; }
        public int UnitPrice { get; set; }
        public List<IDiscount> Discounts { get; set; }
    }
}

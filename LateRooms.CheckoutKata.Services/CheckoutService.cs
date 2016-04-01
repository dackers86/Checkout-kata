using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LateRooms.CheckoutKata.Domain;

namespace LateRooms.CheckoutKata.Services
{
    public class CheckoutService : ICheckout
    {
        public void Scan(string item)
        {
        }

        public int GetTotalPrice()
        {
            return 1;
        }
    }
}

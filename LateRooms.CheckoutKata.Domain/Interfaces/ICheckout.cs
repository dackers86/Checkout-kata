﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LateRooms.CheckoutKata.Domain
{
    public interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}

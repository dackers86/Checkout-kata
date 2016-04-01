using System;
using LateRooms.CheckoutKata.Domain.Interfaces;
using LateRooms.CheckoutKata.Domain.Models;
using System.Collections.Generic;

namespace LateRooms.CheckoutKata.Services
{
    public class ProductService : IProductService
    {
        public Item GetItem(string Name)
        {
            return new Item();
        }
    }
}
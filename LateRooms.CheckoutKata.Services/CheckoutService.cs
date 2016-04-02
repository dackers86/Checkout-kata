using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LateRooms.CheckoutKata.Domain;
using LateRooms.CheckoutKata.Domain.Interfaces;
using LateRooms.CheckoutKata.Domain.Models;

namespace LateRooms.CheckoutKata.Services
{
    public class CheckoutService : ICheckout
    {
        private IProductService _productService;
        private List<Item> _items;

        public CheckoutService(IProductService productService)
        {
            _productService = productService;
            _items = new List<Item>();
        }


        public void Scan(string item)
        {
            var product = _productService.GetItem(item);

            if (product.SKU == "B" && _items.Any(x => x.SKU == product.SKU))
            {
                product.UnitPrice = product.UnitPrice / 2;
            }

            _items.Add(product);
        }

        public int GetTotalPrice()
        {
            return _items.Sum(x => x.UnitPrice);
        }
    }
}

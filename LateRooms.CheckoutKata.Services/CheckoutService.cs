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
        private IDiscountService _discountService;
        private List<Item> _items;

        public CheckoutService(IProductService productService, IDiscountService discountService)
        {
            _productService = productService;
            _discountService = discountService;
            _items = new List<Item>();
        }


        public void Scan(string item)
        {
            var product = _productService.GetItem(item);
            _discountService.ApplyDiscounts(_items, product);

            _items.Add(product);
        }

        public int GetTotalPrice()
        {
            return _items.Sum(x => x.UnitPrice);
        }
    }
}

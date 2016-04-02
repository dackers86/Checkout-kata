using LateRooms.CheckoutKata.Domain.Interfaces;
using LateRooms.CheckoutKata.Domain.Models;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LateRooms.CheckoutKata.Services.Test
{
    public class DiscountServiceTests
    {
        [Fact]
        public void WhenThreeItemDiscountIsApplied_ThenTheUnitPriceShouldBeCorrectlyUpdated()
        {
            // Arrange
            var service = new DiscountService();

            var item1 = new Item { SKU = "A", UnitPrice = 30 };
            var item2 = new Item { SKU = "A", UnitPrice = 30 };
            var item3 = new Item { SKU = "A", UnitPrice = 30 };

            var items = new List<Item> { item1, item2 };

            // Act
            service.ApplyDiscounts(items, item3);

            // Assert
            Assert.Equal(item3.UnitPrice, 10);
        }
    }
}

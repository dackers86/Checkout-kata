using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using NSubstitute;
using LateRooms.CheckoutKata.Domain.Interfaces;
using LateRooms.CheckoutKata.Domain.Models;

namespace LateRooms.CheckoutKata.Services.Test
{
    public class CheckoutServiceTests
    {
        [Fact]
        public void WhenScanningAnItem_ThenTheTotalPriceShouldBeCorrectlyUpdated()
        {
            // Arrange
            var productService = Substitute.For<IProductService>();
            productService.GetItem("A").Returns(new Item { SKU = "A", UnitPrice = 1 });

            var service = new CheckoutService(productService);

            // Act
            service.Scan("A");

            // Assert
            Assert.Equal(service.GetTotalPrice(), 1);
        }

        [Fact]
        public void WhenScanningMultipleItems_ThenTheTotalPriceShouldBeCorrectlyUpdated()
        {
            // Arrange
            var productService = Substitute.For<IProductService>();
            productService.GetItem("A").Returns(new Item { SKU = "A", UnitPrice = 1 });
            productService.GetItem("B").Returns(new Item { SKU = "B", UnitPrice = 1 });

            var service = new CheckoutService(productService);

            // Act
            service.Scan("A");
            service.Scan("B");

            // Assert
            Assert.Equal(service.GetTotalPrice(), 2);
        }
    }
}

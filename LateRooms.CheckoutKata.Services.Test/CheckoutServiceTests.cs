using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LateRooms.CheckoutKata.Services.Test
{
    public class CheckoutServiceTests
    {
        [Fact]
        void WhenScanningAnItem_ThenTheTotalPriceShouldBeUpdated()
        {
            // Arrange
            var service = new CheckoutService();

            // Act
            service.Scan("example item");

            // Assert
            Assert.Equal(service.GetTotalPrice(), 1);
        }
    }
}

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
        public void WhenScanningAnItem_ThenTheTotalPriceShouldBeUpdated()
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

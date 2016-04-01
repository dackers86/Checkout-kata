using LateRooms.CheckoutKata.Domain.Models;

namespace LateRooms.CheckoutKata.Domain.Interfaces
{
    public interface IProductService
    {
        Item GetItem(string Name);
    }
}

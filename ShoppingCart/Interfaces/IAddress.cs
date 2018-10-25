using ShoppingCart.Models;

namespace ShoppingCart.Interfaces
{
    public interface IAddress
    {
        Address GetAddressDetails(int userID);
    }
}
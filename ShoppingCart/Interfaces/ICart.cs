using ShoppingCart.Models;

namespace ShoppingCart.Interfaces
{
    public interface ICart
    {
        Product GetItemDetails(int itemID);
        bool CheckItemAvailability(Product product);
        bool LockItemInStock(int itemID, int quantity);
        int AddItemToChart(int itemID, int quantity);
        double GetCartPrice(int cartID);
    }
}
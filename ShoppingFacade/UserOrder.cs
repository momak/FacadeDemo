using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Interfaces;
using ShoppingCart.Models;

namespace ShoppingFacade
{
    public class UserOrder : IUserOrder
    {
        public int AddToCart(int itemId, int qty)
        {
            Console.WriteLine("Start AddToCart");
            ICart userCart = new ShoppingCartDetails();
            int cartID = 0;

            //Step 1: Get ITEM
            Product product = userCart.GetItemDetails(itemId);

            //Step 2: Check Availability
            if (userCart.CheckItemAvailability(product))
            {
                //Step 3: Lock ITem in the Stock
                userCart.LockItemInStock(itemId, qty);

                //Step 4: Add Item to the cart
                cartID = userCart.AddItemToChart(itemId, qty);
            }

            Console.WriteLine("End AddToCart");
            return cartID;
        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start PlaceOrderDetails");

        }
    }
}

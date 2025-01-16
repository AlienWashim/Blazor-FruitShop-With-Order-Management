using Fruit_Seller.Models;
using MudBlazor;
using System.Collections.Generic;

namespace Fruit_Seller.Services
{
    public class CartService
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }

        public void AddToCart(Fruit fruit)
        {
            var existingItem = cartItems.FirstOrDefault(item => item.FruitName == fruit.FruitName && item.Price == fruit.Price);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cartItems.Add(new CartItem { FruitName = fruit.FruitName, Price = fruit.Price, Unit = fruit.Unit });
            }
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }
    }
}

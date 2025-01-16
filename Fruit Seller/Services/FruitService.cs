using Fruit_Seller.Models;

namespace Fruit_Seller.Services
{
    public class FruitService
    {
        public List<Fruit> GetFruits()
        {
            return new List<Fruit>
            {
                new Fruit { FruitName = "Apple", Unit = "5kg", Price = 1400, ImageUrl = "Images/apple.jpg" },
                new Fruit { FruitName = "Mango", Unit = "10kg", Price = 1500, ImageUrl = "Images/mango.jpg" },
                new Fruit { FruitName = "Apple", Unit = "1kg", Price = 300, ImageUrl = "Images/apple.jpg" },
                new Fruit { FruitName = "Banana", Unit = "1Dozen", Price = 80, ImageUrl = "Images/banana.jpg" },
                new Fruit { FruitName = "Banana", Unit = "2Dozen", Price = 150, ImageUrl = "Images/banana.jpg" },
                new Fruit { FruitName = "Orange", Unit = "2kg", Price = 700, ImageUrl = "Images/orange.jpg" },
                new Fruit { FruitName = "Orange", Unit = "1kg", Price = 360, ImageUrl = "Images/orange.jpg" },
                new Fruit { FruitName = "Mango", Unit = "5kg", Price = 800, ImageUrl = "Images/mango.jpg" },
                new Fruit { FruitName = "Mango", Unit = "1kg", Price = 180, ImageUrl = "Images/mango.jpg" }
            };
        }
    }
}

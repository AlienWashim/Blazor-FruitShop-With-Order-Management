namespace Fruit_Seller.Models
{
    public class CartItem
    {
        public string FruitName { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } = 1;
    }
}


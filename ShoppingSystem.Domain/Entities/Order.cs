using System;

namespace ShoppingSystem.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int AmountOfProduct { get; set; }
        public User User { get; set; }
        public decimal Price => Product.Price * AmountOfProduct;
        public DateTime CreatedDate { get; private set; }

        public Order()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
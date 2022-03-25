using System;

namespace ShoppingSystem.Domain.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public User User { get; set; }
        public decimal Price => Product.Price * Amount;
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
    }
}
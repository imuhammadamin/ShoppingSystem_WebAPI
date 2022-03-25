using ShoppingSystem.Domain.Enums;

namespace ShoppingSystem.Domain.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Colors Color { get; set; }
        public decimal Price { get; set; }
        public Companies CompanyName { get; set; }
    }
}
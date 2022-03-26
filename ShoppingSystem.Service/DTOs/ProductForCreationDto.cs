using ShoppingSystem.Domain.Enums;

namespace ShoppingSystem.Service.DTOs
{
    public class ProductForCreationDto
    {
        public string Name { get; set; }
        public Colors Color { get; set; }
        public decimal Price { get; set; }
        public Companies CompanyName { get; set; }
    }
}
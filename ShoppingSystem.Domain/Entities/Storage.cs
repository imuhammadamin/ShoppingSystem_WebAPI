namespace ShoppingSystem.Domain.Entities
{
    public class Storage
    {
        public long Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
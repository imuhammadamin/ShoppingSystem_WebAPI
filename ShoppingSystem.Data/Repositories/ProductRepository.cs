using ShoppingSystem.Data.Contexts;
using ShoppingSystem.Data.IRepositories;
using ShoppingSystem.Domain.Entities;

namespace ShoppingSystem.Data.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}

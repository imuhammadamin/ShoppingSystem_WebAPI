using ShoppingSystem.Data.Contexts;
using ShoppingSystem.Data.IRepositories;
using ShoppingSystem.Domain.Entities;

namespace ShoppingSystem.Data.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}

using ShoppingSystem.Data.Contexts;
using ShoppingSystem.Data.IRepositories;
using ShoppingSystem.Domain.Entities;

namespace ShoppingSystem.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}

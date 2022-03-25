using ShoppingSystem.Data.Contexts;
using ShoppingSystem.Data.IRepositories;
using ShoppingSystem.Domain.Entities;

namespace ShoppingSystem.Data.Repositories
{
    public class StorageRepository : GenericRepository<Storage>, IStorageRepository
    {
        public StorageRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}
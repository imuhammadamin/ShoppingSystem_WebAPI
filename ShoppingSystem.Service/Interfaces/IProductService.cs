using ShoppingSystem.Domain.Configurations;
using ShoppingSystem.Domain.Entities;
using ShoppingSystem.Service.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingSystem.Service.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateAsync(ProductForCreationDto productDto);
        Task<Product> GetAsync(long id);
        Task<Product> UpdateAsync(ProductForCreationDto product);
        Task<bool> DeleteAsync(long id);
        Task<IQueryable<Product>> GetAll(PaginationParams @params);
    }
}
using ShoppingSystem.Data.IRepositories;
using ShoppingSystem.Domain.Configurations;
using ShoppingSystem.Domain.Entities;
using ShoppingSystem.Service.DTOs;
using ShoppingSystem.Service.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingSystem.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepo;
        public ProductService(IProductRepository productRepo)
        {
            this.productRepo = productRepo;
        }

        public Task<Product> CreateAsync(ProductForCreationDto productDto)
        {
            return productRepo.CreateAsync
                (
                    new Product
                    {
                        Name = productDto.Name,
                        Color = productDto.Color,
                        Price = productDto.Price,
                        CompanyName = productDto.CompanyName
                    }
                );
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IQueryable<Product>> GetAll(PaginationParams @params)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> UpdateAsync(ProductForCreationDto product)
        {
            throw new System.NotImplementedException();
        }
    }
}
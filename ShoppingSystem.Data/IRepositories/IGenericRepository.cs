using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShoppingSystem.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T source);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<T> UpdateAsync(T source);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);
        Task<IQueryable<T>> GetAll(Expression<Func<T, bool>> expression = null);
    }
}
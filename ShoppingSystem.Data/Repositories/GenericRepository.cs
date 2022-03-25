using Microsoft.EntityFrameworkCore;
using ShoppingSystem.Data.Contexts;
using ShoppingSystem.Data.IRepositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShoppingSystem.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal ShopDbContext shopDbContext;
        internal DbSet<T> dbSet;

        public GenericRepository(ShopDbContext shopDbContext)
        {
            this.shopDbContext = shopDbContext;
            this.dbSet = shopDbContext.Set<T>();
        }

        public async Task<T> CreateAsync(T source)
        {
            var entry = await dbSet.AddAsync(source);

            await shopDbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            T source = dbSet.FirstOrDefault(expression);
            
            if (source == null)
                return false;

            dbSet.Remove(source);

            await shopDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IQueryable<T>> GetAll(Expression<Func<T, bool>> expression = null)
        {
            return expression == null ? dbSet : dbSet.Where(expression);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<T> UpdateAsync(T source)
        {
            dbSet.Update(source);

            await shopDbContext.SaveChangesAsync();

            return source;
        }
    }
}
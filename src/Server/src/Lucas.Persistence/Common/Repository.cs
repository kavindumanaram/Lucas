using Lucas.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lucas.Persistence.Common
{
    public class Repository<LucasContext> : IRepository where LucasContext : DbContext
    {
        protected LucasContext dbContext;

        public Repository(LucasContext context)
        {
            dbContext = context;
        }


        public async Task CreateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Add(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Remove(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> FindAll<T>() where T : class
        {
            return await this.dbContext.Set<T>().ToListAsync();

        }

        public async Task<T> FindById<T>(int id) where T : class
        {
            return await this.dbContext.Set<T>().FindAsync(id);

        }

        public async Task UpdateAsync<T>(T entity) where T : class
        {
            this.dbContext.Set<T>().Update(entity);

            _ = await this.dbContext.SaveChangesAsync();
        }

    }
}

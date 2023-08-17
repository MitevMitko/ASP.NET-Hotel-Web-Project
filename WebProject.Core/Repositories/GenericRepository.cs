namespace WebProject.Core.Repositories
{
    using Microsoft.EntityFrameworkCore;

    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System;

    using IRepositories;
    using Infrastucture.Data;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<T>> AllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByGuidIdAsync(Guid id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetByIntIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<bool> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);

            return true;
        }
    }
}

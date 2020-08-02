namespace Planty.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Planty.Data.Context;
    using Planty.Data.Interfaces;

    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly DatabaseContext _context;

        public GenericRepository(DatabaseContext context)
        {
            if (context != null)
            {
                _context = context;
            }
        }

        public IQueryable<TEntity> All { get => _context.Set<TEntity>(); }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}

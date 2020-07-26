namespace Planty.Data.Repositories
{
    using System;
    using System.Linq;
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

        public IQueryable<TEntity> All { get; }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().SingleOrDefault(s => s.Id == id);
        }

        public void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}

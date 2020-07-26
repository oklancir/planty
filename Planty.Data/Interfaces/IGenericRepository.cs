namespace Planty.Data.Interfaces
{
    using System;
    using System.Linq;

    public interface IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> All { get; }

        TEntity GetById(Guid id);

        void Insert(TEntity entity);

        void Delete(TEntity entity);
    }
}

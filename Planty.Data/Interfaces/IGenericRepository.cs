namespace Planty.Data.Interfaces
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IGenericRepository<TEntity>
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> All { get; }

        Task<TEntity> GetByIdAsync(Guid id);

        Task InsertAsync(TEntity entity);

        void Delete(TEntity entity);
    }
}

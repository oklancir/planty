namespace Planty.Data.Interfaces
{
    using System.Linq;

    public interface IReadOnlyRepository<out TEntity>
        where TEntity : class, IEntity
    {
        IQueryable<TEntity> AsReadOnly();
    }
}

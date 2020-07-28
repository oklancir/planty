namespace Planty.Data.Repositories
{
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Planty.Data.Interfaces;

    public class ReadOnlyRepository<TEntity> : IReadOnlyRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly IReadOnlyDatabaseContext _readOnlyContext;

        public ReadOnlyRepository(IReadOnlyDatabaseContext readOnlyContext)
        {
            _readOnlyContext = readOnlyContext;
        }

        public IQueryable<TEntity> AsReadOnly()
        {
            return _readOnlyContext.Set<TEntity>().AsNoTracking();
        }
    }
}

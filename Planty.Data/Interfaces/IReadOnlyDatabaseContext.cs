namespace Planty.Data.Interfaces
{
    using Microsoft.EntityFrameworkCore;

    public interface IReadOnlyDatabaseContext
    {
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;
    }
}

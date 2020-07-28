namespace Planty.Data.Context
{
    using Microsoft.EntityFrameworkCore;
    using Planty.Data.Interfaces;

    public class DatabaseContext : DbContext, IReadOnlyDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
    }
}

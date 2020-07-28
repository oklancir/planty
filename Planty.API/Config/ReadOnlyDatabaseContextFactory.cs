namespace Planty.API.Config
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Planty.Data.Context;
    using Planty.Data.Interfaces;

    public static class ReadOnlyDatabaseContextFactory
    {
        public static Func<IServiceProvider, IReadOnlyDatabaseContext> Instance(IConfiguration configuration)
        {
            return provider =>
            {
                var connnectionString = configuration?.GetConnectionString("Planty_DB");

                if (string.IsNullOrWhiteSpace(connnectionString))
                {
                    return null;
                }

                var builder = new DbContextOptionsBuilder<DatabaseContext>();
                builder.UseSqlServer(connnectionString);

                return new DatabaseContext(builder.Options);
            };
        }
    }
}

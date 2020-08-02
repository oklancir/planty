namespace Planty.Data.Repositories
{
    using System.Threading.Tasks;
    using Planty.Data.Context;
    using Planty.Data.Interfaces;

    public class DatabaseScope : IDatabaseScope
    {
        private readonly DatabaseContext _context;

        public DatabaseScope(DatabaseContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

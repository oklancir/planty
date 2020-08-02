using System.Threading.Tasks;

namespace Planty.Data.Interfaces
{
    public interface IDatabaseScope
    {
        Task SaveChangesAsync();
    }
}

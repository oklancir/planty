namespace Planty.Data.Interfaces
{
    using System.Threading.Tasks;

    public interface IDatabaseScope
    {
        Task SaveChangesAsync();
    }
}

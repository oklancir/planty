namespace Planty.Business
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Planty.Data.Entities;

    public interface IPlantService
    {
        Task<IEnumerable<Plant>> GetAllAsync();

        Task<Plant> CreateAsync(Plant plant);

        Task UpdateAsync(Guid id, Plant plant);

        Task DeleteAsync(Guid id);

        Task<Plant> GetByIdAsync(Guid id);

        Task<IEnumerable<Plant>> GetByTypeIdAsync();
    }
}

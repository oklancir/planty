namespace Planty.Business
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Planty.Business.Models;

    public interface IPlantService
    {
        Task<IEnumerable<Plant>> GetAllAsync();

        Task<Plant> CreateAsync(PlantBase model);

        Task<Plant> UpdateAsync(Guid id, PlantBase model);

        Task DeleteAsync(Guid id);

        Task<Plant> GetByIdAsync(Guid id);
    }
}

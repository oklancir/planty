namespace Planty.Business
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Planty.Business.Models;

    public interface IPlantService
    {
        Task<IEnumerable<Plant>> GetAllAsync();

        Task<Plant> CreateAsync(PlantBase plant);

        Task<Plant> UpdateAsync(Guid id, PlantBase plant);

        Task DeleteAsync(Guid id);

        Task<Plant> GetByIdAsync(Guid id);
    }
}

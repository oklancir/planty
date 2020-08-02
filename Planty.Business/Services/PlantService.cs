namespace Planty.Business.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Planty.Common.Extensions;
    using Planty.Data.Entities;
    using Planty.Data.Interfaces;

    public class PlantService : IPlantService
    {
        private readonly IGenericRepository<Plant> _genericRepository;

        private readonly IDatabaseScope _databaseScope;

        public PlantService(IGenericRepository<Plant> genericRepository, IDatabaseScope databaseScope)
        {
            _genericRepository = genericRepository;
            _databaseScope = databaseScope;
        }

        public async Task<Plant> CreateAsync(Plant plant)
        {
            await _genericRepository.InsertAsync(plant);
            return plant;
        }

        public async Task DeleteAsync(Guid id)
        {
            var plant = await _genericRepository.GetByIdAsync(id);

            plant.ValidateIsNotNull(nameof(plant));

            _genericRepository.Delete(plant);
            await _databaseScope.SaveChangesAsync();
        }

        public async Task<IEnumerable<Plant>> GetAllAsync()
        {
            return await _genericRepository.All.ToListAsync();
        }

        public async Task<Plant> GetByIdAsync(Guid id)
        {
            var plant = await _genericRepository.GetByIdAsync(id);

            plant.ValidateIsNotNull(nameof(plant));

            // TODO: Setup AutoMapper for DTOs
            return plant;
        }

        public async Task<IEnumerable<Plant>> GetByTypeIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Guid id, Plant plant)
        {
            plant.ValidateIsNotNull(nameof(plant));

            var entity = await _genericRepository.GetByIdAsync(id);

            entity.ValidateIsNotNull(nameof(entity));

            entity.LatinName = plant.LatinName;
            entity.Name = plant.Name;
            entity.Price = plant.Price;
            entity.Quantity = plant.Quantity;

            await _databaseScope.SaveChangesAsync();
        }
    }
}

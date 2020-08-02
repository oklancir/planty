namespace Planty.Business.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using Planty.Business.Models;
    using Planty.Common.Extensions;
    using Planty.Data.Interfaces;
    using Entities = Planty.Data.Entities;

    public class PlantService : IPlantService
    {
        private readonly IGenericRepository<Entities.Plant> _genericRepository;
        private readonly IDatabaseScope _databaseScope;
        private readonly IMapper _mapper;

        public PlantService(IGenericRepository<Entities.Plant> genericRepository, IDatabaseScope databaseScope, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _databaseScope = databaseScope;
            _mapper = mapper;
        }

        public async Task<Plant> CreateAsync(PlantBase model)
        {
            model.ValidateIsNotNull(nameof(model));

            var entity = new Entities.Plant();
            UpdateEntity(model, entity);

            await _genericRepository.InsertAsync(entity);
            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<Plant>(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));

            _genericRepository.Delete(entity);
            await _databaseScope.SaveChangesAsync();
        }

        public async Task<IEnumerable<Plant>> GetAllAsync()
        {
            return await _genericRepository.All.ProjectTo<Plant>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<Plant> GetByIdAsync(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));

            return _mapper.Map<Plant>(entity);
        }

        public async Task<Plant> UpdateAsync(Guid id, PlantBase model)
        {
            model.ValidateIsNotNull(nameof(model));

            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));
            UpdateEntity(model, entity);

            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<Plant>(entity);
        }

        private static void UpdateEntity(PlantBase model, Entities.Plant entity)
        {
            entity.Name = model.Name;
            entity.LatinName = model.LatinName;
            entity.Price = model.Price;
            entity.Quantity = model.Quantity;
        }
    }
}

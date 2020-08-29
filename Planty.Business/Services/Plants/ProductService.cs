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

    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Entities.Product> _genericRepository;
        private readonly IDatabaseScope _databaseScope;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Entities.Product> genericRepository, IDatabaseScope databaseScope, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _databaseScope = databaseScope;
            _mapper = mapper;
        }

        public async Task<Product> CreateAsync(ProductBase model)
        {
            model.ValidateIsNotNull(nameof(model));

            var entity = new Entities.Product();
            UpdateEntity(model, entity);

            await _genericRepository.InsertAsync(entity);
            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<Product>(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));

            _genericRepository.Delete(entity);
            await _databaseScope.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _genericRepository.All.ProjectTo<Product>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));

            return _mapper.Map<Product>(entity);
        }

        public async Task<Product> UpdateAsync(Guid id, ProductBase model)
        {
            model.ValidateIsNotNull(nameof(model));

            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));
            UpdateEntity(model, entity);

            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<Product>(entity);
        }

        private static void UpdateEntity(ProductBase model, Entities.Product entity)
        {
            entity.Name = model.Name;
            entity.LatinName = model.LatinName;
            entity.Price = model.Price;
            entity.Quantity = model.Quantity;
        }
    }
}

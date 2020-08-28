namespace Planty.Business.Services.Users
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

    public class UserService : IUserService
    {
        private readonly IGenericRepository<Entities.User> _genericRepository;
        private readonly IDatabaseScope _databaseScope;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<Entities.User> genericRepository, IDatabaseScope databaseScope, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _databaseScope = databaseScope;
            _mapper = mapper;
        }

        public async Task<User> CreateAsync(UserBase model)
        {
            model.ValidateIsNotNull(nameof(model));

            var entity = new Entities.User();
            UpdateEntity(model, entity);

            await _genericRepository.InsertAsync(entity);
            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<User>(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));

            _genericRepository.Delete(entity);
            await _databaseScope.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _genericRepository.All.ProjectTo<User>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id);
            entity.RejectEntityNotFound(nameof(entity));

            return _mapper.Map<User>(entity);
        }

        public async Task<User> UpdateAsync(Guid id, UserBase model)
        {
            model.ValidateIsNotNull(nameof(model));

            var entity = await _genericRepository.GetByIdAsync(id);
            entity.ValidateIsNotNull(nameof(entity));
            UpdateEntity(model, entity);

            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<User>(entity);
        }

        private static void UpdateEntity(UserBase model, Entities.User entity)
        {
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Email = model.Email;
            entity.DateOfBirth = model.DateOfBirth;
            entity.Username = model.Username;
        }
    }
}

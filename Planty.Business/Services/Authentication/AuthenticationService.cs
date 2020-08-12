namespace Planty.Business.Services
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Planty.Business.Models;
    using Planty.Business.Services.Authentication;
    using Planty.Common.Extensions;
    using Planty.Data.Interfaces;
    using Entities = Planty.Data.Entities;

    public class AuthenticationService
    {
        private readonly IGenericRepository<Entities.User> _genericRepository;
        private readonly IDatabaseScope _databaseScope;
        private readonly IMapper _mapper;

        public AuthenticationService(IGenericRepository<Entities.User> genericRepository, IDatabaseScope databaseScope, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _databaseScope = databaseScope;
            _mapper = mapper;
        }

        public async Task<User> RegisterAsync(UserBase user)
        {
            user.ValidateIsNotNull(nameof(user));

            var passwordSalt = CryptographyService.CreateSalt();
            var passwordHash = CryptographyService.CreateHash(user.Password, passwordSalt);

            var userEntity = new Entities.User();
            userEntity.PasswordHash = passwordHash;
            userEntity.PasswordSalt = passwordSalt;
            userEntity.FirstName = user.FirstName;
            userEntity.LastName = user.LastName;
            userEntity.DateOfBirth = user.DateOfBirth;
            userEntity.Email = user.Email;

            await _genericRepository.InsertAsync(userEntity);
            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<User>(userEntity);
        }

        public Task<User> LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}

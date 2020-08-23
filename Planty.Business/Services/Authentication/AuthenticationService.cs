namespace Planty.Business.Services
{
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
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

        public async Task<User> RegisterAsync(UserBase model)
        {
            model.ValidateIsNotNull(nameof(model));
            var userExists = await UserExistsAsync(model.Username);
            var emailInUse = await EmailInUseAsync(model.Email);

            if (userExists || emailInUse)
            {
                return null;
            }

            var passwordSalt = CryptographyService.CreateSalt();
            var passwordHash = CryptographyService.CreateHash(model.Password, passwordSalt);

            var entity = new Entities.User();
            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Username = model.Username;

            entity.DateOfBirth = model.DateOfBirth;
            entity.Email = model.Email;

            await _genericRepository.InsertAsync(entity);
            await _databaseScope.SaveChangesAsync();

            return _mapper.Map<User>(entity);
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            var entity = await _genericRepository.All.FirstOrDefaultAsync(user => user.Username == username);
            entity.ValidateIsNotNull(nameof(entity));

            var passwordHash = CryptographyService.CreateHash(password, entity.PasswordSalt);

            if (entity.PasswordHash != passwordHash)
            {
                return null;
            }

            return _mapper.Map<User>(entity);
        }

        public async Task<bool> UserExistsAsync(string username)
        {
            var entity = await _genericRepository.All.FirstOrDefaultAsync(user => user.Username == username);
            entity.ValidateIsNotNull(nameof(entity));

            if (entity != null)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> EmailInUseAsync(string email)
        {
            var entity = await _genericRepository.All.FirstOrDefaultAsync(user => user.Email == email);
            entity.ValidateIsNotNull(nameof(entity));

            return entity != null;
        }
    }
}

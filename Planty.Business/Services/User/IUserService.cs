namespace Planty.Business.Services.User
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Planty.Business.Models;

    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<User> CreateAsync(UserBase model);

        Task<User> UpdateAsync(Guid id, UserBase model);

        Task DeleteAsync(Guid id);

        Task<User> GetByIdAsync(Guid id);
    }
}

namespace Planty.Business
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Planty.Business.Models;

    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product> CreateAsync(ProductBase model);

        Task<Product> UpdateAsync(Guid id, ProductBase model);

        Task DeleteAsync(Guid id);

        Task<Product> GetByIdAsync(Guid id);
    }
}

using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetListAsync();
        Task<List<Product>> GetListByIdAsync(int id);
        Task<List<Product>> GetByCategoryAsync(int categoryId);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}

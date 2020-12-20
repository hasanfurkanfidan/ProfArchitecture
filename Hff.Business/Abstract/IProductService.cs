using Hff.Core.Utilities.Results;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Business.Abstract
{
    public interface IProductService
    {
        Task<IDataResult<List<Product>>> GetListAsync();
        Task<IDataResult<List<Product>>> GetListByCategoryAsync(int categoryId);
        Task<IDataResult<Product>> GetByIdAsync(int id);
        Task<IResult> AddAsync(Product product);
        Task<IResult> UpdateAsync(Product product);
        Task<IResult> DeleteAsync(Product product);
    }
}

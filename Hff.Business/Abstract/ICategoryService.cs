using Hff.Core.Utilities.Results;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Business.Abstract
{
    public interface ICategoryService
    {
        public Task<IDataResult<List<Category>>>GetListAsync();
        public Task<IDataResult<Category>> GetByIdAsync(int id);
        Task<IResult> AddAsync(Category category);
        Task<IResult> UpdateAsync(Category category);
        Task<IResult> DeleteAsync(Category category);

    }
}

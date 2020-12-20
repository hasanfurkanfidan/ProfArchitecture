using Hff.Business.Abstract;
using Hff.Core.Utilities.Results;
using Hff.DataAccess.Abstract;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public async Task<IResult> AddAsync(Category category)
        {
            try
            {
                await _categoryDal.AddAsync(category);
                return new SuccessResult("Category added successfully.");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message,"Business.CategoryManager.AddAsync");                
            }
        }

        public async Task<IResult> DeleteAsync(Category category)
        {
            try
            {
                await _categoryDal.DeleteAsync(category);
                return new SuccessResult("Category deleted successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message,"Business.CategoryManager.DeleteAsync");
            }
        }

        public async Task<IDataResult<Category>> GetByIdAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Category>(await _categoryDal.GetAsync(p => p.CategoryId == id));
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<Category>(await _categoryDal.GetAsync(p => p.CategoryId == id), ex.Message);
            }
        }

        public async Task<IDataResult<List<Category>>> GetListAsync()
        {
            try
            {
                return new SuccessDataResult<List<Category>>(await _categoryDal.GetListAsync());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Category>>(await _categoryDal.GetListAsync(),ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(Category category)
        {
            try
            {
                await _categoryDal.UpdateAsync(category);
                return new SuccessResult("Category updated successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message, "Business.CategoryManager.UpdateAsync");
            }
        }
    }
}

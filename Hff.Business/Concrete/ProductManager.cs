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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<IResult> AddAsync(Product product)
        {
            try
            {
                await _productDal.AddAsync(product);
                return new SuccessResult("Product added successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message,"Business.ProductManager.AddAsync");
            }
        }

        public async Task<IResult> DeleteAsync(Product product)
        {
            try
            {
                await _productDal.DeleteAsync(product);
                return new SuccessResult("Product added successfully");
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message, "Business.ProductManager.DeleteAsync");
            }
        }

        public async Task<IDataResult<Product>> GetByIdAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Product>(await _productDal.GetAsync(p => p.ProductId == id));     
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Product>(await _productDal.GetAsync(p => p.ProductId == id),ex.Message);
            }
        }

        public async Task<IDataResult<List<Product>>> GetListAsync()
        {
            try
            {
                return new SuccessDataResult<List<Product>>(await _productDal.GetListAsync());
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Product>>(await _productDal.GetListAsync(),ex.Message);
            }
        }

        public async Task<IDataResult<List<Product>>> GetListByCategoryAsync(int categoryId)
        {
            try
            {
                return new SuccessDataResult<List<Product>>(await _productDal.GetListAsync(p=>p.CategoryId==categoryId));
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<Product>>(await _productDal.GetListAsync(p=>p.CategoryId==categoryId), ex.Message);
            }
        }

        public async Task<IResult> UpdateAsync(Product product)
        {
            try
            {
                await _productDal.UpdateAsync(product);
                return new SuccessResult(
                    "Product updated successfully"
                    );
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message,"Business.ProductManager.UpdateAsync");
            }
        }
    }
}

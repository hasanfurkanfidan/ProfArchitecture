using Hff.Business.Abstract;
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

        public async Task AddAsync(Product product)
        {
            await _productDal.AddAsync(product);
        }

        public async Task DeleteAsync(Product product)
        {
            await _productDal.DeleteAsync(product);
        }

        public async Task<List<Product>> GetByCategoryAsync(int categoryId)
        {
            return await _productDal.GetListAsync(p => p.CategoryId == categoryId);
        }

        public async Task<List<Product>> GetListAsync()
        {
            return await _productDal.GetListAsync();
        }

        public async Task<List<Product>> GetListByIdAsync(int id)
        {
            return await _productDal.GetListAsync(p => p.ProductId == id);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productDal.UpdateAsync(product);
        }
    }
}

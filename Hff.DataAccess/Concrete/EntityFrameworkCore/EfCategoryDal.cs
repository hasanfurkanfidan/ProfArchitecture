using Hff.Core.DataAccess.EntityFrameworkCore;
using Hff.DataAccess.Abstract;
using Hff.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}

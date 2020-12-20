using Hff.Business.Abstract;
using Hff.Business.Concrete;
using Hff.DataAccess.Abstract;
using Hff.DataAccess.Concrete.EntityFrameworkCore;
using Hff.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            //Business
            services.AddScoped<IProductService, ProductManager>();
            //DataAccess
            services.AddScoped<IProductDal, EfProductDal>();
            services.AddScoped<DbContext, NorthwindContext>();
        }
    }
}

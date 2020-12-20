using Hff.Core.DataAccess.EntityFrameworkCore;
using Hff.DataAccess.Abstract;
using Hff.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hff.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public Task<List<OperationClaim>> GetClaims(User user)
        {
            var context = new NorthwindContext();
            var result = from operationClaim in context.OperationClaims
                         join userOperationClaim in context.UserOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim
                         {
                             Id = operationClaim.Id,
                             Name = operationClaim.Name

                         };
            return  result.ToListAsync();
        }
    }
}

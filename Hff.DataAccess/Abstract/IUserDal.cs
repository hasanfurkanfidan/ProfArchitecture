using Hff.Core.DataAccess;
using Hff.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        Task<List<OperationClaim>> GetClaims(User user);
    }
}

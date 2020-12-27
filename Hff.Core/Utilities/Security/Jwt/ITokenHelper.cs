using Hff.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
       AccessToken CreateToken(User user,List<OperationClaim>claims);
    }
}

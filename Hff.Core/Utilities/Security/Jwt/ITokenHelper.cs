using Hff.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user);
    }
}

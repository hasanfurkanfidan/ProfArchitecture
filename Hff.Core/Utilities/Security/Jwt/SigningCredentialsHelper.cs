using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Core.Utilities.Security.Jwt
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials GetSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
        }
    }
}

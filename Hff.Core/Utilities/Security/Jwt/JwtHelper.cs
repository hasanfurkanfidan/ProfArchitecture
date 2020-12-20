using Hff.Core.Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Hff.Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get;}
        private readonly TokenOptions _tokenOptions;
        DateTime _accessTokenExpiration;
        public JwtHelper(IConfiguration configuration,TokenOptions tokenOptions)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            _accessTokenExpiration = DateTime.Now.Add(_tokenOptions.AccessTokenExpiration);
        }
        public async Task<AccessToken> CreateTokenAsync(User user, List<OperationClaim> claims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.GetSigningCredentials(securityKey);

        }
        public JwtSecurityToken CreateJwtToken(TokenOptions tokenOptions,User user,SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(issuer: tokenOptions.Issuer, audience: tokenOptions.Audience,expires: _accessTokenExpiration, notBefore: DateTime.Now, claims: operationClaims, signingCredentials: signingCredentials);
            
        }
        private IEnumerable<Claim>SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim
            {

            });
        }
    }
}

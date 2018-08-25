using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Globalization;
using Basics.Security;

namespace Erpmi.Security
{
    public class JwtFactory : Basics.Security.JwtFactory
    {
        public JwtFactory(IOptions<JwtIssuerOptions> jwtOptions) : base(jwtOptions) { }

        public override ClaimsIdentity GenerateClaimsIdentity(string email, int id)
        {
            return new ClaimsIdentity(new GenericIdentity(email, "Token"), new[]
            {
                new Claim(JwtClaimIdentifiers.Id, id.ToString()),
                //TODO: Replace this dummy claim with actual claims from the database
                new Claim(JwtClaimIdentifiers.ExampleClaim, JwtClaims.ApiAccess)
            });
        }
    }
}
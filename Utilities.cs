using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using AspNet.Security.OpenIdConnect.Primitives;


namespace Erpmi.Security
{
    public static class Utilities
    {
        public static int GetUserId(ClaimsPrincipal user)
        {
            return Convert.ToInt32(user.FindFirst(OpenIdConnectConstants.Claims.Subject)?.Value?.Trim());
        }



        public static string[] GetRoles(ClaimsPrincipal identity)
        {
            return identity.Claims
                .Where(c => c.Type == OpenIdConnectConstants.Claims.Role)
                .Select(c => c.Value)
                .ToArray();
        }
    }
}

// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Erpmi.Security
{
    public class ViewRoleAuthorizationRequirement : IAuthorizationRequirement
    {

    }



    public class ViewRoleAuthorizationHandler : AuthorizationHandler<ViewRoleAuthorizationRequirement, string>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ViewRoleAuthorizationRequirement requirement, string roleName)
        {
            if (context.User == null)
                return Task.CompletedTask;

            if (context.User.HasClaim(ClaimTypes.Permission, Permissions.ViewRoles) || context.User.IsInRole(roleName))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}

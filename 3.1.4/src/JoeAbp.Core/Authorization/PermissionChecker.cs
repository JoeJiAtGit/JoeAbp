using Abp.Authorization;
using JoeAbp.Authorization.Roles;
using JoeAbp.Authorization.Users;

namespace JoeAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

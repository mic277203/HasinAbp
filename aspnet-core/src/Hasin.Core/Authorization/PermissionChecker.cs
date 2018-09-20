using Abp.Authorization;
using Hasin.Authorization.Roles;
using Hasin.Authorization.Users;

namespace Hasin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

using Abp.Authorization;
using ABCCommunity.Authorization.Roles;
using ABCCommunity.Authorization.Users;

namespace ABCCommunity.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

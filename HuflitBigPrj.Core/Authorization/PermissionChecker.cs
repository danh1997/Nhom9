using Abp.Authorization;
using HuflitBigPrj.Authorization.Roles;
using HuflitBigPrj.Authorization.Users;

namespace HuflitBigPrj.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

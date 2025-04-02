using Abp.Authorization;
using MyFirstProj.Authorization.Roles;
using MyFirstProj.Authorization.Users;

namespace MyFirstProj.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}

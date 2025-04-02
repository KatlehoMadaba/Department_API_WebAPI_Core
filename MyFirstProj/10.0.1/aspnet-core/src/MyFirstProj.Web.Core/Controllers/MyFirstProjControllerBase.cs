using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyFirstProj.Controllers
{
    public abstract class MyFirstProjControllerBase : AbpController
    {
        protected MyFirstProjControllerBase()
        {
            LocalizationSourceName = MyFirstProjConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

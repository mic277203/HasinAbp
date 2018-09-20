using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Hasin.Controllers
{
    public abstract class HasinControllerBase: AbpController
    {
        protected HasinControllerBase()
        {
            LocalizationSourceName = HasinConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

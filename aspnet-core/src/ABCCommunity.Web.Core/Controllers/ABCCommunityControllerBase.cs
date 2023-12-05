using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABCCommunity.Controllers
{
    public abstract class ABCCommunityControllerBase: AbpController
    {
        protected ABCCommunityControllerBase()
        {
            LocalizationSourceName = ABCCommunityConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

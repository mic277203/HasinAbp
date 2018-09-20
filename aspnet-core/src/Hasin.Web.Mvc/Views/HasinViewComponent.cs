using Abp.AspNetCore.Mvc.ViewComponents;

namespace Hasin.Web.Views
{
    public abstract class HasinViewComponent : AbpViewComponent
    {
        protected HasinViewComponent()
        {
            LocalizationSourceName = HasinConsts.LocalizationSourceName;
        }
    }
}

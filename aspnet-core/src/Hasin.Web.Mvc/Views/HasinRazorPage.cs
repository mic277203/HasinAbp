using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Hasin.Web.Views
{
    public abstract class HasinRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HasinRazorPage()
        {
            LocalizationSourceName = HasinConsts.LocalizationSourceName;
        }
    }
}

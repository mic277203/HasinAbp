using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Hasin.Controllers;

namespace Hasin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : HasinControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

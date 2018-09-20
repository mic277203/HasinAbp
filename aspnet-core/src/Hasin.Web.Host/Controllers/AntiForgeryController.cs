using Microsoft.AspNetCore.Antiforgery;
using Hasin.Controllers;

namespace Hasin.Web.Host.Controllers
{
    public class AntiForgeryController : HasinControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

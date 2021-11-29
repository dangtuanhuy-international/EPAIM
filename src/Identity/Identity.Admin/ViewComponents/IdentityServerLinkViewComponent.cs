using Identity.Admin.Configuration.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Admin.ViewComponents
{
    public class IdentityServerLinkViewComponent : ViewComponent
    {
        private readonly IRootConfiguration _configuration;

        public IdentityServerLinkViewComponent(IRootConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IViewComponentResult Invoke()
        {
            var identityServerUrl = _configuration.AdminConfiguration.IdentityServerBaseUrl;

            return View(model: identityServerUrl);
        }
    }
}
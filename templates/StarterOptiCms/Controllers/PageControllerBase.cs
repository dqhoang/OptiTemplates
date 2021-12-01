using EPiServer.Web.Mvc;
using StarterOptiCms.Models.Pages;

namespace StarterOptiCms
{
    public abstract class PageControllerBase<T> : PageController<T>
        where T : SitePageData
    {

    }
}
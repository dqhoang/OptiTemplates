using System.Threading.Tasks;
using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using StarterOptiCms.Models;

namespace StarterOptiCms
{
    public abstract class PageControllerBase<T> : PageController<T>
        where T : SitePageData
        {

        }
}
using StarterOptiCms.Models.Pages;
using EPiServer;
using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using StarterOptiCms.Models.ViewModels;
using System;

namespace StarterOptiCms
{
    /// <summary>
    /// Concrete controller that handles all page types that don't have their own specific controllers.
    /// </summary>
    [TemplateDescriptor(Inherited = true)]
    public class DefaultPageController : PageControllerBase<SitePageData>
    {
        public ViewResult Index(SitePageData currentPage)
        {
            var model = CreateModel(currentPage);
            return View(string.Format("~/Views/{0}/Index.cshtml", currentPage.GetOriginalType().Name), model);
        }

        /// <summary>
        /// Creates a PageViewModel where the type parameter is the type of the page.
        /// </summary>
        private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}
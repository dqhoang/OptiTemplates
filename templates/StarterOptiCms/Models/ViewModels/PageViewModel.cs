using System;
using EPiServer.Core;
using StarterOptiCms.Models.Pages;

namespace StarterOptiCms
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage { get; private set; }
    }

    public static class PageViewModel
    {
        /// <summary>
        /// Returns a PageViewModel of type <typeparam name="T"/>.
        /// </summary>
        public static PageViewModel<T> Create<T>(T page) where T : SitePageData
        {
            return new PageViewModel<T>(page);
        }
    }
}
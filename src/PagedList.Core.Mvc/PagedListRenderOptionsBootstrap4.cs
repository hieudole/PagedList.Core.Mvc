namespace PagedList.Core.Mvc
{
    ///<summary>
    /// Options for configuring the output of <see cref = "HtmlHelper" />.
    ///</summary>
    public partial class PagedListRenderOptions
    {
        private const string DefaultContainerHtmlTag = "nav";

        private static readonly string[] DefaultUlElementClasses = { "pagination" };

        private static readonly string[] DefaultLiElementClasses = { "page-item" };

        private static readonly string[] DefaultAhrefElementClasses = { "page-link" };

        private const string DefaultLinkToPreviousPageFormat = "Previous";

        private const string DefaultLinkToNextPageFormat = "Next";

        private const string DefaultLinkToFirstPageFormat = "First";

        private const string DefaultLinkToLastPageFormat = "Last";

        private static PagedListRenderOptions GetBootstrap4Option()
        {
            return new PagedListRenderOptions
            {
                ContainerHtmlTag = DefaultContainerHtmlTag,
                UlElementClasses = DefaultUlElementClasses,
                LiElementClasses = DefaultLiElementClasses,
                AhrefElementClasses = DefaultAhrefElementClasses,
                LinkToPreviousPageFormat = DefaultLinkToPreviousPageFormat,
                LinkToNextPageFormat = DefaultLinkToNextPageFormat,
                LinkToFirstPageFormat = DefaultLinkToFirstPageFormat,
                LinkToLastPageFormat = DefaultLinkToLastPageFormat
            };
        }

        /// <summary>
        /// Show Numbers, First, Last, Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4
        {
            get
            {
                var option = GetBootstrap4Option();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
                option.DisplayLinkToIndividualPages = true;
                option.ClassToApplyToFirstListItemInPager = null;
                option.ClassToApplyToLastListItemInPager = null;

                return option;
            }
        }

        /// <summary>
        /// Show Numbers, First, Last, Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions Bootstrap4Full
        {
            get
            {
                var option = GetBootstrap4Option();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Always;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Always;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
                option.DisplayLinkToIndividualPages = true;
                option.ClassToApplyToFirstListItemInPager = null;
                option.ClassToApplyToLastListItemInPager = null;

                return option;
            }
        }

        ///<summary>
        /// Shows only the Number links.
        ///</summary>
        public static PagedListRenderOptions Bootstrap4PageNumbersOnly
        {
            get
            {
                var option = GetBootstrap4Option();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Never;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Never;
                option.DisplayLinkToIndividualPages = true;
                option.ClassToApplyToFirstListItemInPager = null;
                option.ClassToApplyToLastListItemInPager = null;

                return option;
            }
        }

        ///<summary>
        /// Shows only the Previous and Next links.
        ///</summary>
        public static PagedListRenderOptions Bootstrap4Minimal
        {
            get
            {
                var option = GetBootstrap4Option();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
                option.DisplayLinkToIndividualPages = false;

                return option;
            }
        }
    }
}
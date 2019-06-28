namespace PagedList.Core.Mvc
{
    ///<summary>
    /// Options for configuring the output of <see cref = "HtmlHelper" />.
    ///</summary>
    public partial class PagedListRenderOptions
    {
        private static void SetMinimalOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
            option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
            option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
            option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
            option.DisplayLinkToIndividualPages = false;
        }

        private static void SetPageNumbersOnlyOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
            option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
            option.DisplayLinkToPreviousPage = PagedListDisplayMode.Never;
            option.DisplayLinkToNextPage = PagedListDisplayMode.Never;
            option.DisplayLinkToIndividualPages = true;
        }

        private static void SetPageNumbersPlusPrevAndNextOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
            option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
            option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
            option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
            option.DisplayLinkToIndividualPages = true;
        }

        private static void SetPageNumbersPlusFirstAndLastOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = PagedListDisplayMode.Always;
            option.DisplayLinkToLastPage = PagedListDisplayMode.Always;
            option.DisplayLinkToPreviousPage = PagedListDisplayMode.Never;
            option.DisplayLinkToNextPage = PagedListDisplayMode.Never;
            option.DisplayLinkToIndividualPages = true;
        }

        private static void SetFullOption(PagedListRenderOptions option)
        {
            option.DisplayLinkToFirstPage = PagedListDisplayMode.Always;
            option.DisplayLinkToLastPage = PagedListDisplayMode.Always;
            option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
            option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
            option.DisplayLinkToIndividualPages = true;
        }

        /// <summary>
        /// Only show Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions Minimal
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetMinimalOption(option);

                return option;
            }
        }

        /// <summary>
        /// Only show Page Numbers.
        /// </summary>
        public static PagedListRenderOptions PageNumbersOnly
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetPageNumbersOnlyOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus Previous and Next links.
        /// </summary>
        public static PagedListRenderOptions PageNumbersPlusPrevAndNext
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetPageNumbersPlusPrevAndNextOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus First and Last links.
        /// </summary>
        public static PagedListRenderOptions PageNumbersPlusFirstAndLast
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetPageNumbersPlusFirstAndLastOption(option);

                return option;
            }
        }

        /// <summary>
        /// Show Page Numbers plus Previous, Next, First and Last links.
        /// </summary>
        public static PagedListRenderOptions Full
        {
            get
            {
                var option = new PagedListRenderOptions();

                SetFullOption(option);

                return option;
            }
        }
    }
}
namespace PagedList.Core.Mvc.Sample.Pagination
{
    public class SitePagedListRenderOptions
    {
        public static PagedListRenderOptions Boostrap4
        {
            get
            {
                var option = PagedListRenderOptions.Bootstrap4Full;

                option.MaximumPageNumbersToDisplay = 5;

                return option;
            }
        }

        public static PagedListRenderOptions Boostrap4CustomizedText
        {
            get
            {
                var option = PagedListRenderOptions.Bootstrap4Full;

                option.MaximumPageNumbersToDisplay = 5;
                option.LinkToPreviousPageFormat = "<";
                option.LinkToNextPageFormat = ">";
                option.LinkToFirstPageFormat = "<<";
                option.LinkToLastPageFormat = ">>";

                return option;
            }
        }
    }
}

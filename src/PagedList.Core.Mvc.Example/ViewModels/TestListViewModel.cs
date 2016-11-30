using PagedList.Core.Mvc.Example.Models;

namespace PagedList.Core.Mvc.Example.ViewModels
{
    public class TestListViewModel
    {
        public IPagedList<TestModel> Tests { get; set; }
    }
}

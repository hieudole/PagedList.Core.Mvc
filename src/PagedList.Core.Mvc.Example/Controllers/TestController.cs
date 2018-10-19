using Microsoft.AspNetCore.Mvc;
using PagedList.Core.Mvc.Example.Services;
using PagedList.Core.Mvc.Example.Models;

namespace PagedList.Core.Mvc.Example.Controllers
{
    public class TestController : Controller
    {
        private TestService testService;

        public TestController()
        {
            this.testService = new TestService();
        }

        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
                        
            var viewModel = new TestListViewModel();
            viewModel.Tests = this.testService.GetTests(pageNumber, pageSize);

            return View(viewModel);
        }
    }
}

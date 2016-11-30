using PagedList.Core.Mvc.Example.Models;
using System.Collections.Generic;
using System.Linq;

namespace PagedList.Core.Mvc.Example.Services
{
    public class TestService
    {
        private static List<TestModel> SampleTests = new List<TestModel>()
        {
            new TestModel()
            {
                Name = "Test 1"
            },
            new TestModel()
            {
                Name = "Test 2"
            },
            new TestModel()
            {
                Name = "Test 3"
            },
            new TestModel()
            {
                Name = "Test 4"
            },
            new TestModel()
            {
                Name = "Test 5"
            },
            new TestModel()
            {
                Name = "Test 6"
            },
            new TestModel()
            {
                Name = "Test 7"
            },
            new TestModel()
            {
                Name = "Test 8"
            },
            new TestModel()
            {
                Name = "Test 9"
            },
            new TestModel()
            {
                Name = "Test 10"
            },
            new TestModel()
            {
                Name = "Test 11"
            },
            new TestModel()
            {
                Name = "Test 12"
            },
            new TestModel()
            {
                Name = "Test 13"
            },
            new TestModel()
            {
                Name = "Test 14"
            },
            new TestModel()
            {
                Name = "Test 15"
            }
        };

        public IPagedList<TestModel> GetTests(int pageNumber, int pageSize)
        {
            var tests = SampleTests.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            return new StaticPagedList<TestModel>(tests, pageNumber, pageSize, SampleTests.Count);
        }
    }
}

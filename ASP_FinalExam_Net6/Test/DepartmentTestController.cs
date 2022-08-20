using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_FinalExam_Net6.Controllers;
using ASP_FinalExam_Net6.Data;
using ASP_FinalExam_Net6.Models;
using Xunit;

namespace ASP_FinalExam_Net6.Test
{
    public class DepartmentTestController : Controller
    {
        private IEnumerable<object> fakeDepartments;

        [Fact]
        public async Task Index_Basic_Test()
        {
            using (var testDb = new ApplicationDbContext(this.GetTestDbOpts()))
            {
                var testCtrl = new DepartmentsController(testDb);
                var res = await testCtrl.Index();
                var resVr = Assert.IsType<ViewResult>(res);
                Assert.IsAssignableFrom<IEnumerable<Department>>(resVr.ViewData.Model);
            }
        }

     

        // Create the DB Context to use (note this should be a test database)
        private DbContextOptions<ApplicationDbContext> GetTestDbOpts()
        {
            var opts = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=W10_Example_Test.Data;Trusted_Connection=True;MultipleActiveResultSets=true").Options;
            return opts;
        }

       
    }
}

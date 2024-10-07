using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateofBirth = new DateTime(1954,12,01)
            };
            return View(data);
        }
    }
}

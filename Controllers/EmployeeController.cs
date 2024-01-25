using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace InvestorSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace InvestorManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

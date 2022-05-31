using Microsoft.AspNetCore.Mvc;

namespace InvestorManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

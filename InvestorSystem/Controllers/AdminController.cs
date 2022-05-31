using Microsoft.AspNetCore.Mvc;

namespace InvestorSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

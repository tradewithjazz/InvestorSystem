using Microsoft.AspNetCore.Mvc;

namespace InvestorSystem.Controllers
{
    public class BranchManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

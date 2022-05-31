using Microsoft.AspNetCore.Mvc;

namespace InvestorManagementSystem.Controllers
{
    public class BranchManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

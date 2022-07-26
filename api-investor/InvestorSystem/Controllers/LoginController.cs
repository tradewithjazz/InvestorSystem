using InvestorSystem.Core.Areas.Login;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvestorSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string email,string password)
        {
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                var result = _loginService.ValidateUser(email, password);

                if (result == string.Empty)
                {
                    return BadRequest("Invalid credentials");
                }

                return Ok(result);
            }

            return BadRequest();
        }

        [Authorize]
        [HttpGet]
        [Route("GetGenders")]
        public IActionResult GetGenders()
        { 
            return Ok(_loginService.GetGenders());
        }
    }
}

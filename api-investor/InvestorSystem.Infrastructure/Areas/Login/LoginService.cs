using InvestorSystem.Core.Areas.Login;
using InvestorSystem.DataModel.Table;
using InvestorSystem.Infrastructure.DB;
using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Infrastructure.Areas.Login
{
    public class LoginService : ILoginService
    {
        private readonly AppDBContext dBContext;
        public IConfiguration configuration;
        public LoginService(AppDBContext dBContext, IConfiguration config)
        {
            this.dBContext = dBContext;
            this.configuration = config;
        }

        public string ValidateUser(string username, string password)
        {
            var user = dBContext.Users.FirstOrDefault(u => u.UserEmail == username && u.Password == password);

            if (user != null)
            {
                var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("DisplayName", user.DisplayName),
                        new Claim("UserName", user.UserName),
                        new Claim("Email", user.UserEmail)
                    };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(10),
                    signingCredentials: signIn);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }

            return string.Empty;
        }

        public IList<Gender> GetGenders()
        {
            return dBContext.Gender.ToList();
        }
    }
}

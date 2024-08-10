using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace BookStoreAPI.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost, Route("login")]
        public IActionResult Login(LoginModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid client request");
            }
            if (model.UserName == "hanabee" && model.Password == "hanabeeme")
            {
                var data = Encoding.UTF8.GetBytes(_configuration["Secret"] ?? string.Empty);
                var securityKey = new SymmetricSecurityKey(data);

                var claims = new Dictionary<string, object>
                {
                    [ClaimTypes.Name] = "Hannah Baker",
                    [ClaimTypes.GroupSid] = "872f7f3c-730f-4381-8e2f-736c84f6ec90",
                    [ClaimTypes.Sid] = "3c545f1c-cc1b-4cd5-985b-8666886f985b",
                    [ClaimTypes.Role] = new List<string> { "Admin", "User" }
                };
                var descriptor = new SecurityTokenDescriptor
                {
                    Issuer = "Hanabee.me",
                    Audience = "https://localhost:5000",
                    Claims = claims,
                    IssuedAt = DateTime.Now,
                    NotBefore = DateTime.UtcNow,
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    SigningCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
                };

                var handler = new Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenHandler();
                handler.SetDefaultTimesOnTokenCreation = false;
                var tokenString = handler.CreateToken(descriptor);

                return Ok(new { Barer = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }

    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

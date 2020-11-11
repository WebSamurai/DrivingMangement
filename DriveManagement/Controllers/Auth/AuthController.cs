using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DriveDomain.DomainServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DriveManagement.Controllers.Auth
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserDomainService userDomainService;

        public AuthController(IUserDomainService userDomainService)
        {
            this.userDomainService = userDomainService;
        }
        [HttpPost, Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }
            var saveduser = await userDomainService.Find(x => x.UserName == user.UserName && x.Password == user.Password);
            if (saveduser!= null)
            {
            
            //if (user.UserName == "admin" && user.Password == "admin123")
            //{
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken
                (
                issuer: "http://localhost:60000",
                audience: "http://localhost:60000",
                claims: new List<Claim>(),
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                setTokenCookie(tokenString);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
           

        }
        private void setTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddMinutes(30)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }
    }
}

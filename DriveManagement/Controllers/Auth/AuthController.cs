using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DriveDomain.DomainServices;
using DriveManagement.Middleware;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DriveManagement.Controllers.Auth
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserDomainService userDomainService;
        private readonly AppSettings _appSettings;


        public AuthController(IUserDomainService userDomainService, IOptions<AppSettings> appSettings)
        {
            this.userDomainService = userDomainService;
            _appSettings = appSettings.Value;

        }
        [HttpPost, Route("Login")]
        public async Task<AuthencateResultModel> Login([FromBody] LoginModel user)
        {
            if (user == null)
            {
              throw new UnauthorizedAccessException("Invalid client request");
            }
            var saveduser = await userDomainService.Find(x => x.UserName == user.UserName && x.Password == user.Password);
            if (saveduser!= null)
            {
                string token = GetToken(saveduser);
                return new AuthencateResultModel (saveduser,token);
            }
            else
            {

                throw new UnauthorizedAccessException("UnAuthozied");
            }
           

        }

        private string GetToken(DriveDomain.DomainDtos.UserDto saveduser)
        {
            //way 1


            //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            //var secretKey = new SymmetricSecurityKey(key);
            //var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            //var tokenOptions = new JwtSecurityToken
            //(
            //issuer: "http://localhost:60000",
            //audience: "http://localhost:60000",
            //claims: new List<Claim>(),
            //expires: DateTime.Now.AddMinutes(30),
            //signingCredentials: signinCredentials
            //);
            //var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
         

            //way t2
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", saveduser.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var stringToken = tokenHandler.WriteToken(token);
            setTokenCookie(stringToken);
            return stringToken;
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

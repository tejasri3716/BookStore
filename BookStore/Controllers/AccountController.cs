using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Users> userManager;
        private readonly SignInManager<Users> signInManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<Users> userManager,
            SignInManager<Users> signInManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("api/register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel register)
        {
            if (ModelState.IsValid)
            {
                var user = new Users()
                {
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    UserName = register.Email,
                    Email = register.Email,
                    EmailConfirmed = true
                };
                var result = await this.userManager.CreateAsync(user, register.Password);
                if(result.Succeeded)
                {
                    return Ok(new { result });
                }
                else
                {
                    return BadRequest("Enter Correct Credentials");
                }
            }
            else
                return BadRequest("Error : Object is not valid");
        }

        [HttpPost]
        [Route("api/login")]
        public async Task<IActionResult> Login([FromBody]LoginModel login)
        {
            if(ModelState.IsValid)
            {
                var result = await this.signInManager.PasswordSignInAsync(login.Email, login.Password, isPersistent: false, false);
                if(result.Succeeded)
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                        this.configuration["Jwt:secretKey"]));
                    var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub,login.Email),
                        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.UniqueName,login.Email)
                    };
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:url"],
                        audience: configuration["Jwt:url"],
                        claims, 
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: cred);
                    var securityToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return this.Ok(new {Token= securityToken});
                }
                else
                {
                    return this.BadRequest("Enter Correct Credentials");
                }
            }
            else
            {
                return this.BadRequest();
            }
        }


    }

}

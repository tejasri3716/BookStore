using Microsoft.IdentityModel.Tokens;
using Model.UserModel;
using Repository.Context;
using Repository.IRepository;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserContext userContext;
        public AccountRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }

        public AccountRepository()
        {
        }

        public async Task<RegisterModel> EmailLogin(LoginModel login)
        {
            var jwtSetting = new JwtSettings();
            var result=this.userContext.Accountregister.Where(option => option.Email==login.Email).SingleOrDefault();
            if(result != null)
            {
                try
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwtSetting.Secret"));
                    var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credential
                        );
                    var cacheKey = login.Email;
                    ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase data = multiplexer.GetDatabase();
                    data.StringSet(cacheKey, token.ToString());
                    data.StringGet(cacheKey);
                    result.Status = true;
                    await this.userContext.SaveChangesAsync();
                    return result;
                }
                catch(Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
            return default;
        }

        public async Task<RegisterModel> FaceBookLogin(LoginModel login)
        {
            var jwt = new JwtSettings();
            var result = this.userContext.Accountregister.Where(option => option.Email == login.Email).SingleOrDefault();
            if (result != null)
            {
                try
                {
                    var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwt.Secret"));
                    var credential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credential
                        );
                    var cacheKey = login.Email;
                    ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase data = multiplexer.GetDatabase();
                    data.StringSet(cacheKey, token.ToString());
                    data.StringGet(cacheKey);
                    result.Status = true;
                    await this.userContext.SaveChangesAsync();
                    return result;
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
            return default;
        }

        public async Task<string> ForgotPassword(ForgotPassword forgotPassword)
        {
            var user = CheckEmail(forgotPassword.Email);
            if (user == true)
            {
                var fromAddress = new MailAddress("tejasmiley129@gmail.com");
                var fromPassword = "9553302822";
                var toAddress = new MailAddress(forgotPassword.Email);
                string subject = "Reset Password";
                string body = "To reset your password click the below given link :- " +
                    " http://localhost:44324/api/reset";
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                    try
                    {
                        smtp.Send(message);
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                await Task.Run(() => this.userContext.SaveChangesAsync());
                return "Success";
            }
            return null;
        }
        public Task<int> RegisterAccount(RegisterModel register)
        {
            RegisterModel registerModel = new RegisterModel()
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                Password = register.Password
            };
            var rrr = this.userContext.Accountregister.Add(register);
            var result = this.userContext.SaveChanges();
            return Task.Run(() => result);
        }

        public async Task<string> Login(LoginModel login)
        {
            LoginModel loginModel = new LoginModel();
            var check = CheckEmail(login.Email);
            var result = CheckPassword(login.Email, login.Password);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Email",login.Email),    
                    new Claim("Password",login.Password)
                }),
            };
            var descriptor = tokenHandler.CreateToken(tokenDescriptor);
            var securityToken = tokenHandler.WriteToken(descriptor);
            var res = this.userContext.SaveChangesAsync();
            //await Task.Run(() => userContext.SaveChanges());
            return "Logged In Successfully";
        }

        public bool CheckEmail(string email)
        {
            var result = userContext.Accountregister.Where(option => option.Email == email).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckPassword(string email, string password)
        {
            var result = userContext.Accountregister.Where(option => option.Email == email && option.Password == password).FirstOrDefault();
            if(result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<string> ResetPassword(ResetPassword reset)
        {
            string password = reset.Password;
            RegisterModel model= this.userContext.Accountregister.Where<RegisterModel>(option =>
             option.Password == password).FirstOrDefault();
            if(model != null)
            {
                string pwd = reset.ConfirmPassword;
                model.Password = pwd;
                this.userContext.Update(model);
                await Task.Run(() => this.userContext.SaveChangesAsync());
                return "success";
            }
            return null;
        }
    }

}

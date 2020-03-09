﻿namespace FundooApp.Controllers
{
    using Manager.IManager;
    using Microsoft.AspNetCore.Mvc;
    using Model.UserModel;
    using System;
    using System.Threading.Tasks;

    public class AccountController : ControllerBase
    {
        /// <summary>
        /// The account manager
        /// </summary>
        private readonly IAccountManager accountManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public AccountController(IAccountManager manager)
        {
            this.accountManager = manager;
        }

        /// <summary>
        /// Registers the specified register.
        /// </summary>
        /// <param name="register">The register.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/register")]
        public ActionResult Register([FromBody]RegisterModel register)
        {
            try
            {
                var res = this.accountManager.Register(register);
                return Ok(register);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Logins the specified login details.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/login")]
        public ActionResult Login([FromBody]LoginModel loginModel)
        {
            try
            {
                var result = this.accountManager.Login(loginModel);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Forgot password.
        /// </summary>
        /// <param name="forgotPassword">The forgot password.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/forget")]
        public async Task<IActionResult> ForgotPassword([FromBody]ForgotPassword forgotPassword)
        {
            try
            {
                var result = await this.accountManager.ForgotPassword(forgotPassword);

                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/reset")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword reset)
        {
            try
            {
                var result = await this.accountManager.ResetPassword(reset);
                return Ok(result);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Email login.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/emailLogin")]
        public async Task<IActionResult> EmailLogin([FromBody]LoginModel login)
        {
            try
            {
                var result = await this.accountManager.EmailLogin(login);
                return Ok();
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        /// <summary>
        /// Facebook login.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/faceBookLogin")]
        public async Task<IActionResult> FaceBookLogin([FromBody]LoginModel login)
        {
            try
            {
                var result = await this.accountManager.FaceBookLogin(login);
                return Ok(result);
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}

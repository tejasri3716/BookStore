// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ForgotPassword.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.UserModel
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Forgot Password class is used to send link to email address
    /// </summary>
    public class ForgotPassword
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;

        [EmailAddress]
        public string Email { get => email; set => email = value; }
    }
}
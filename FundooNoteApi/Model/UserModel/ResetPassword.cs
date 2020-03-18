// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ResetPassword.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.UserModel
{
    /// <summary>
    /// Reset Password class is used to reset the existing password
    /// </summary>
    public class ResetPassword
    {
        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The old password
        /// </summary>
        private string password;

        /// <summary>
        /// Creates new password.
        /// </summary>
        private string newPassword;

        /// <summary>
        /// The confirm password
        /// </summary>
        private string confirmPassword;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get => password; set => password = value; }

        /// <summary>
        /// Creates new password.
        /// </summary>
        /// <value>
        /// The new password.
        /// </value>
        public string NewPassword { get => newPassword; set => newPassword = value; }

        /// <summary>
        /// Gets or sets the confirm password.
        /// </summary>
        /// <value>
        /// The confirm password.
        /// </value>
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
    }
}
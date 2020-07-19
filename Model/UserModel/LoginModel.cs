using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    public class LoginModel
    {
        private int id;
        /// <summary>
        /// The email
        /// </summary>
        private string email;

        /// <summary>
        /// The password
        /// </summary>
        private string password;

        [Required(ErrorMessage = "E-mail id is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get => email; set => email = value; }

        [Required]
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
    }
}

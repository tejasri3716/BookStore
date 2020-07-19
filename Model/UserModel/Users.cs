using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.UserModel
{
    public class Users : IdentityUser
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The email
        /// </summary>
        private string email;

        private string profilePic;

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Maximum 30 characters")]
        public string FirstName { get => this.firstName; set => this.firstName = value; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Required(ErrorMessage ="Last Name is required")]
        [StringLength(16, MinimumLength = 4, ErrorMessage = "Maximum 30 characters")]
        public string LastName { get => this.lastName; set => this.lastName = value; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Key]
        [Required(ErrorMessage = "E-mail id is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public override string Email { get => this.email; set => this.email = value; }

        public string ProfilePic { get => this.profilePic; set => this.profilePic = value; }

    }
}

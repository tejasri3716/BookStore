using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    public class Employee
    {
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        [Required]
        public string FirstName { get => this.firstname; set => this.firstname = value; }
        [Required]
        public string LastName { get => this.lastname; set => this.lastname = value; }
        [Required]
        public string Email { get => this.email; set => this.email = value; }
        [Required]
        public string Password { get => this.password; set => this.password = value; }
    }
}
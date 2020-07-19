using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.WishList
{
    public class WishListModel
    {
        
        private int id;
        private int bookId;
        private string email;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "bookId is required")]
        public int BookId { get => bookId; set => bookId = value; }

        [Required(ErrorMessage = "E-mail id is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get => email; set => email = value; }
    }
}
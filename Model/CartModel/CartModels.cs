using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.CartModel
{
    public class CartModels
    {
        private int bookId;
        private int id;
        private string email;
        private int quantity;

        public int BookId { get => bookId; set => bookId = value; }
        [Key]
        public int Id { get => id; set => id = value; }
        [EmailAddress]
        public string Email { get => email; set => email = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
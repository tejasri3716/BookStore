using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Orders
{
    public class Orders
    {
        private int bookId;
        private int orderId;
        private int id;
        private string email;
        private int quantity;

        [Required]
        public int BookId { get => bookId; set => bookId = value; }


        [Key]
        public int Id { get => id; set => id = value; }

        [Required,EmailAddress]
        public string Email { get => email; set => email = value; }

        [Required]
        public int Quantity { get => quantity; set => quantity = value; }

        public int OrderId { get => orderId; set => orderId = value; }
    }
}

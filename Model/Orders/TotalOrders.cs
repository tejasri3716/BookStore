using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Orders
{
    public class TotalOrders
    {
        private int orderId;
        private string email;

        [Key]
        public int OrderId { get => orderId; set => orderId = value; }
        public string Email { get => email; set => email = value; }
    }
}

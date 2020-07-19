using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model.BooksModel;
using Model.CartModel;
using Model.CustomerModel;
using Model.Orders;
using Model.UserModel;
using Model.WishList;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class UserContext : IdentityDbContext<Users>
    {
        public UserContext(DbContextOptions<UserContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Users> Accountregister { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<CartModels> Cart { get; set; }
        public DbSet<CustomerModels> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<TotalOrders> AllOrders { get; set; }
        public DbSet<WishListModel> WishList { get; set; }
    }
}

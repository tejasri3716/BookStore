using Manager.IManager;
using Model.CartModel;
using Repository.IRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class CartManager : ICartManager
    {
        private readonly ICartRepo cartRepo;

        public CartManager(ICartRepo cartRepo)
        {
            this.cartRepo = cartRepo;
        }
        public async Task<int> AddtoCart(CartModels cart)
        {
            return await this.cartRepo.AddtoCart(cart);
        }

        public async Task<int> DeleteFromCart(int id)
        {
            return await this.cartRepo.DeleteFromCart(id);
        }

        public IEnumerable<object> GetAllBooks(string email)
        {
            return this.cartRepo.GetAllBooks(email);
        }
        public async Task<int> UpdateBook(List<CartModels> cartModels)
        {
            return await this.cartRepo.UpdateBook(cartModels);
        }
    }
}

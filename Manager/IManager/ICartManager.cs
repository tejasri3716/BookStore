using Model.CartModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IManager
{
    public interface ICartManager
    {
        Task<int> AddtoCart(CartModels cart);
        Task<int> DeleteFromCart(int id);
        IEnumerable<object> GetAllBooks(string email);
        Task<int> UpdateBook(List<CartModels> cartModels);
    }
}

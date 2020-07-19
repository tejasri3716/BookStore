using Model.WishList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IManager
{
    public interface IWishListManager
    {
        Task<int> AddToWishList(WishListModel wish);
        Task<int> DeleteFromWishList(int id);
        IEnumerable<object> GetAllBooks(string email);
    }
}

using Model.WishList;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IWishListRepo
    {
        Task<int> AddToWishList(WishListModel wish);
        IEnumerable<object> GetAllBooks(string email);
        Task<int> DeleteFromWishList(int id);
    }
}

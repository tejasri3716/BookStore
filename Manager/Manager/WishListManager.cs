using Manager.IManager;
using Model.WishList;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class WishListManager : IWishListManager
    {
        private readonly IWishListRepo wish;

        public WishListManager(IWishListRepo wish)
        {
            this.wish = wish;
        }
        public async Task<int> AddToWishList(WishListModel wishListModel)
        {
            return await this.wish.AddToWishList(wishListModel);
        }

        public async Task<int> DeleteFromWishList(int id)
        {
            return await this.wish.DeleteFromWishList(id);
        }

        public IEnumerable<object> GetAllBooks(string email)
        {
            return this.wish.GetAllBooks(email);
        }
    }
}

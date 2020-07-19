using Microsoft.EntityFrameworkCore;
using Model.WishList;
using Repository.Context;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryClasses
{
    public class WishListRepo : IWishListRepo
    {
        private readonly UserContext user;

        public WishListRepo(UserContext user)
        {
            this.user = user;
        }

        public async Task<int> AddToWishList(WishListModel wish)
        {
            WishListModel wishList = new WishListModel()
            {
                Email = wish.Email,
                BookId = wish.BookId
            };
            await this.user.WishList.AddAsync(wish);
            return await this.user.SaveChangesAsync();
        }

        public async Task<int> DeleteFromWishList(int id)
        {
            var book = this.user.WishList.Where(op => op.Id == id || op.BookId.Equals(id)).SingleOrDefault();
            if(book!=null)
            {
                this.user.WishList.Remove(book);
            }
            return await this.user.SaveChangesAsync();
        }

        public IEnumerable<object> GetAllBooks(string email)
        {
            var result = (from books in this.user.Books
                          join book in this.user.WishList.Where(op => op.Email == email) on books.BookId
                          equals book.BookId
                          orderby books.BookId
                          select new
                          {
                              books.BookId,
                              books.BookTitle,
                              books.BookDescription,
                              books.BookPrice,
                              books.Author,
                              books.NoOfBooks,
                              books.BookImage,
                              book.Id
                          }).ToList();
            return result;
        }
    }
}

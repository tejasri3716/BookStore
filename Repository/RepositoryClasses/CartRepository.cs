using Model.BooksModel;
using Model.CartModel;
using Repository.Context;
using Repository.IRepository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryClasses
{
    public class CartRepository : ICartRepo
    {
        private readonly UserContext user;

        public CartRepository(UserContext user)
        {
            this.user = user;
        }
        public async Task<int> AddtoCart(CartModels cart)
        {
            CartModels cartModel = new CartModels()
            {
                BookId=cart.BookId,
                Email=cart.Email,
                Quantity=cart.Quantity,
            };
            await this.user.Cart.AddAsync(cart);
            return await this.user.SaveChangesAsync();
        }

        public async Task<int> DeleteFromCart(int id)
        {
            var book = this.user.Cart.Where(op => op.Id.Equals(id) || op.BookId.Equals(id)).SingleOrDefault();
            if(book!=null)
            {
                this.user.Cart.Remove(book);
            }
            return await this.user.SaveChangesAsync();
        }

        public IEnumerable<object> GetAllBooks(string email)
        {
            var result = (from books in this.user.Books
                          join bookInCart in this.user.Cart.Where(op => op.Email == email) on books.BookId
                          equals bookInCart.BookId orderby books.BookId
                          select new {
                              books.BookId,
                              books.BookTitle,
                              books.BookDescription,
                              books.BookPrice,
                              books.Author,
                              books.NoOfBooks,
                              books.BookImage,
                              bookInCart.Quantity,
                              bookInCart.Id
                          }).ToList();
            return  result;
        }

        public async Task<int> UpdateBook(List<CartModels> cartModels)
        {
            var noOfRows = 0;
            foreach (var book in cartModels)
            {
                var result = await this.user.Cart.FindAsync(book.Id);
                this.user.Entry(result).CurrentValues.SetValues(book);
                noOfRows = await this.user.SaveChangesAsync();
            }
            return noOfRows;
        }
    }
}

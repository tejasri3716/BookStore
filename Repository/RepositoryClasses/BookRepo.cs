
using Model.BooksModel;
using Model.CartModel;
using Repository.Context;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryClasses
{
    public class BookRepo : IBookStore
    {
        private readonly UserContext context;
        public BookRepo(UserContext user)
        {
            this.context = user;
        }
        public async Task<int> AddBook(Books book)
        {
            Books books = new Books()
            {
                BookId = book.BookId,
                BookTitle = book.BookTitle,
                BookDescription = book.BookDescription,
                BookPrice = book.BookPrice,
                BookImage = book.BookImage,
                Author = book.Author,
                NoOfBooks = book.NoOfBooks,
            };
            await this.context.Books.AddAsync(book);
            
            return await this.context.SaveChangesAsync();
        }
        public async Task<int> DeleteBook(int id)
        {
            var book = this.context.Books.Where(op => op.BookId == id).SingleOrDefault();
            if (book != null)
            {
                this.context.Books.Remove(book);
                return await this.context.SaveChangesAsync();
            }
            else
                return 0;
        }

        public async Task<List<Books>> GetAllBooks()
        {
            await this.context.SaveChangesAsync();
            return this.context.Books.ToList();
        }

        public List<Books> GetBook(int id)
        {
            var note = this.context.Books.Where(option => option.BookId == id).SingleOrDefault();
            if (note != null)
            {
                return context.Books.Where(option => option.BookId == id).ToList();
            }
            return null;
        }
    }
}

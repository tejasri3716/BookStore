using Manager.IManager;
using Model.BooksModel;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Manager
{
    public class BooksManger : IBooksManager
    {
        private readonly IBookStore book;

        public BooksManger(IBookStore book)
        {
            this.book = book;
        }
        public async Task<int> AddBook(Books books)
        {
            return await this.book.AddBook(books);
        }

        public async Task<int> DeleteBook(int id)
        {
            return await this.book.DeleteBook(id);
        }

        public async Task<List<Books>> GetAllBooks()
        {
            return await this.book.GetAllBooks();
        }

        public List<Books> GetBook(int id)
        {
            return this.book.GetBook(id);
        }
    }
}

using Model.BooksModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IBookStore
    {
        Task<int> AddBook(Books book);

        Task<int> DeleteBook(int id);

        Task<List<Books>> GetAllBooks();

        List<Books> GetBook(int id);
    }
}

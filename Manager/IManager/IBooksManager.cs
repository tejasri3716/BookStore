using Model.BooksModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.IManager
{
    public interface IBooksManager
    {
        Task<int> AddBook(Books books);
        Task<int> DeleteBook(int id);
        Task<List<Books>> GetAllBooks();
        List<Books> GetBook(int id);
    }
}

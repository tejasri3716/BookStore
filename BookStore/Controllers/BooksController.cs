using Manager.IManager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Model.BooksModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [Route("api/[Controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksManager booksManager;

        public BooksController(IBooksManager booksManager)
        {
            this.booksManager = booksManager;
        }
        [HttpPost]
        //[Route("api/addbook")]
        public async Task<IActionResult> AddBook([FromBody] Books books)
        {
            if (ModelState.IsValid)
            {
                var result = await this.booksManager.AddBook(books);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (ModelState.IsValid)
            {
                var result = await this.booksManager.DeleteBook(id);
                if (result != 0)
                {
                    return Ok(new { result });
                }
            }
            return BadRequest();
        }

        [HttpGet]
        //[Route("api/getAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            if (ModelState.IsValid)
            {
                List<Books> books = await this.booksManager.GetAllBooks();
                return Ok(books);
            }
            return BadRequest();
        }
        
        //[HttpGet]
        //[Route("api/getBookId")]
        //public IActionResult GetBook(int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = this.booksManager.GetBook(id);
        //        return Ok(result);
        //    }
        //    return BadRequest();
        //}
    }
}

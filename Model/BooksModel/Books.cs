using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.BooksModel
{
    public class Books
    {
        private int bookId;
        private string bookTitle;
        private string bookDescription;
        private string author;
        private int bookPrice;
        private string bookImage;
        private int noOfBooks;

        [Key]
        public int BookId { get => bookId; set => bookId = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string BookDescription { get => bookDescription; set => bookDescription = value; }
        public int BookPrice { get => bookPrice; set => bookPrice = value; }
        public string Author { get => author; set => author = value; }
        public string BookImage { get => bookImage; set => bookImage = value; }
        public int NoOfBooks { get => noOfBooks; set => noOfBooks = value; }
    }
}

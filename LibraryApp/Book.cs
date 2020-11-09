using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book
    {
       private string bookName;
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private string bookAuthor;
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private string bookId;
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private string bookType;
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy; 
        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }
        public Book()
        {
            
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
           this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
           // public void AddBookCopy(int x)
        }
        public void ShowBookInfo()
        {
            Console.WriteLine("Book Name :" + bookName);
            Console.WriteLine("BookAuthor Address :" + bookAuthor);
            Console.WriteLine("BookId  :" + bookId);
            Console.WriteLine("BookType :" + bookType);
            Console.WriteLine("Book Copy:" + bookCopy);
           // Console.WriteLine("Library TotalBook :" + totalBook);
        }
    }
}

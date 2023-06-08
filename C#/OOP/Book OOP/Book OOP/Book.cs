using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_OOP
{
    internal class Book
    {
        private string _bookName;
        private string _author;
        private int _pubYear;
        private int _pages;

        public Book(string bookName, string author, int pubYear, int pages)
        {
            _bookName = bookName;
            _author = author;
            _pubYear = pubYear;
            _pages = pages;
        }

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; } //do i need a setter for this?
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; } //do i need a setter for this?
        }
        public int PubYear
        {
            get { return _pubYear; }
            set { _pubYear = value; } //do i need a setter for this?
        }
        public int Pages
        {
            get { return _pages; }
            set {_pages = value;} //do i need a setter for this?
        }  
    }
}

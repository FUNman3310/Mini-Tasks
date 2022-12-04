using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Task1
{
    public class Library
    {
        private static int _bookCounter;
        public int BookLimit;
        private Book[] bookList = new Book[0];

        static Library()
        {
            _bookCounter = 0;     
        }

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
            Array.Resize(ref bookList, bookLimit);
        }

        public void AddBook(Book book)
        {
            if (_bookCounter<=BookLimit)
            {
                bookList[_bookCounter] = book;
                _bookCounter++;
            }
            else
            {
                throw new IndexOutOfRangeException("Limit of Books!");
            }

            
        }
    }
}

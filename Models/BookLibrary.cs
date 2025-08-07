using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitializingTask.Models
{
    internal class BookLibrary
    {
        string _name;
        Book[] _books = new Book[0];

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 2)
                {
                    _name = value;
                }
            }
        }
        public Book[] Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }

        }

        public void Add(Book book)
        {
            Array.Resize(ref _books, Books.Length + 1);
            Books[Books.Length - 1] = book;

        }
        public void Remove(Book book)
        {
            Book[] newBook = new Book[Books.Length - 1];
            int findIndex = 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] == book)
                {

                    findIndex = i;

                }

            }
            for (int i = 0; i < newBook.Length; i++)
            {
                if (findIndex != i)
                {
                    newBook[i] = Books[i];
                }
                else
                {
                    newBook[i] = Books[i + 1];
                }
            }
            Books = newBook;
        }
        public void ShowAll()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].GetInfo();
            }
        }
        public void BorrowBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    Books[i].IsAvailabla = false;
                    break;
                }
            }
        }
        public void ReturnBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    Books[i].IsAvailabla = true;
                    break;
                }
            }
        }
        public void SearchByAuthor(string name)
        {
            
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Author==name)
                {
                   
                    Books[i].GetInfo();
                }
            }
        }
    }
    }






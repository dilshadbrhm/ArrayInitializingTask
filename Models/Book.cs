using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ArrayInitializingTask.Models
{
    internal class Book
    {
        string _name;
        string _author;
        bool _isAvailable = true;

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
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 2)
                {
                    _author = value;
                }
            }

        }
        public bool IsAvailabla
        {
            get
            {
                return _isAvailable;
            }
            set
            {
                _isAvailable = value;
            }
        }



        public Book(string name, string author)
        {
            Name = name;
            Author = author;


        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name}  {Author}  {IsAvailabla}");
        }


    }
}

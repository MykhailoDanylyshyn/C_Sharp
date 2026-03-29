using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.BooksList
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book() 
        {
            Name = "NoName";
            Author = "NoAuthor";
            Pages = 0;
        }

        public Book(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            Pages = pages;
        }
    }
}

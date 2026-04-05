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

        public override string ToString()
        {
            return $"{Name} - {Author} ({Pages} pages)";
        }

        public static bool operator ==(Book b1, Book b2)
        {
            return b1.Name == b2.Name && b1.Author == b2.Author;
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Book b)
                return this == b;
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Author.GetHashCode();
        }
    }
}
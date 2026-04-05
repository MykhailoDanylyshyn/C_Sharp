using System;

namespace CSharp.BooksList
{
    class BookList
    {
        private Book[] books;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public BookList(int size = 10)
        {
            books = new Book[size];
            count = 0;
        }

        public void Add(Book book)
        {
            if (count < books.Length)
            {
                books[count++] = book;
            }
            else
            {
                Console.WriteLine("Список переповнений!");
            }
        }

        public void Remove(Book book)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i] == book)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[count - 1] = null;
                    count--;
                    return;
                }
            }

            Console.WriteLine("Книгу не знайдено!");
        }

        public bool Contains(Book book)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i] == book)
                    return true;
            }
            return false;
        }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return books[index];
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < count)
                    books[index] = value;
            }
        }

        public static BookList operator +(BookList list, Book book)
        {
            list.Add(book);
            return list;
        }

        public static BookList operator -(BookList list, Book book)
        {
            list.Remove(book);
            return list;
        }

        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
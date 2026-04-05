using CSharp.BooksList;
using System;
using System.Text;

try
{
    BookList list = new BookList();

    Book b1 = new Book("1984", "Orwell", 328);
    Book b2 = new Book("Dune", "Herbert", 412);

    list += b1;
    list += b2;

    list.Show();

    Console.WriteLine(list.Contains(b1)); 

    Console.WriteLine(list[0]);

    list -= b1;

    Console.WriteLine("\nПісля видалення:");
    list.Show();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

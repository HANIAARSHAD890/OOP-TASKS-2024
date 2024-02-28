using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("StageShow", 1234.213F, 10, "Shakespeare", "shakespeare@gmail.com", 'M');
            Book book2 = new Book("The Catcher in the Rye", 19.99F, 25, "J.D. Salinger", "salinger@example.com", 'M');
            Book book3 = new Book("To Kill a Mockingbird", 14.50F, 30, "Harper Lee", "lee@example.com", 'F');
            Book book4 = new Book("1984", 12.99F, 20, "George Orwell", "orwell@example.com", 'M');
            Book book5 = new Book("Pride and Prejudice", 9.99F, 40, "Jane Austen", "austen@example.com", 'F');
            List<Book> ListofBooks= new List<Book>();
            //// get names 
        
            Console.WriteLine("Do you wanted to add the book ");
            string option = Console.ReadLine();
            if (option == "yes")
            {
              Book.BookAdd(book1);
              Book.BookAdd(book2);
              Book.BookAdd(book3);
              Book.BookAdd(book4);
              Book.BookAdd(book5);
            }
            Console.WriteLine("Get all booknames ");
             ListofBooks = Book.GetAllBookList();
            for (int i = 0; i < ListofBooks.Count; i++)
            {
                Console.WriteLine(ListofBooks[i].GetAllBooksNames());
            }

            Console.WriteLine("Set the name   of author of book1 ");
            string name = Console.ReadLine();

            Author author1 = book1.getAuthor();
            author1.SetName(name);
            Console.WriteLine("Get all authornames ");
            ListofBooks = Book.GetAllBookList();
            for (int i = 0; i < ListofBooks.Count; i++)
            { 
                Author  author = ListofBooks[i].getAuthor();
                string AuthorName = author.GetName();
                Console.WriteLine($"Author : {AuthorName}");

            }

        }
    }
}

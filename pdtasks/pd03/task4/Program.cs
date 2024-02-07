using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
     class Program
    {
        static void Main(string[] args)
        {
            //-----declaraing objects of the class
            book book1 = new book("", "", 0, 0, 0);
            book book2 = new book("", "", 0, 0, 0);
            book book3 = new book("", "", 0, 0, 0);
            book book4 = new book("", "", 0, 0, 0);
            book book5 = new book("", "", 0, 0, 0);
            book book6 = new book("", "", 0, 0, 0);
            book book7 = new book("", "", 0, 0, 0);
            book book8 = new book("", "", 0, 0, 0);
            book book9 = new book("", "", 0, 0, 0);
            book book10 = new book("", "", 0, 0, 0);


            // declaring list ofobjects

            List<book> bookList = new List<book>
            { book1,book2,book3,book4,book5,book6,book7,book8,book9,book10 };

            int bookcount = 0;
            //file names 
            Console.WriteLine("BOOK MANAGEMENT SYSTEM");
            Console.WriteLine("ADD book");
            addbook(bookList, ref bookcount);
            Console.WriteLine("ADD book");
            addbook(bookList, ref bookcount);
            Console.WriteLine("SHOW DETAILS");

            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine( bookList[i].Title());
                Console.WriteLine(bookList[i].Author());
                Console.WriteLine(bookList[i].PublicationYear());
                Console.WriteLine(bookList[i].Price());
                Console.WriteLine(bookList[i].QuanttyinStock());
            }
                Console.WriteLine("AUTHORS OF THE BOOKS");

            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine( bookList[i].Title());
                Console.WriteLine(bookList[i].Author());
            }
            Console.WriteLine("Total NO OF COPIES SOLD");
            Console.WriteLine("write title of book ");
            string titleOfbook = Console.ReadLine();
            Console.WriteLine("write no of copies needed to be sold ");
            int sellcopies = int.Parse(Console.ReadLine());
            Console.WriteLine(Sellcopies(bookList, ref bookcount, sellcopies, titleOfbook));
            Console.WriteLine("SHOW DETAILS");

            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine(bookList[i].Title());
                Console.WriteLine(bookList[i].Author());
                Console.WriteLine(bookList[i].PublicationYear());
                Console.WriteLine(bookList[i].Price());
                Console.WriteLine(bookList[i].QuanttyinStock());
            }
            Console.WriteLine("BOOKS TO BE RESTOCKED");
            Console.WriteLine("write title of book ");
            titleOfbook = Console.ReadLine();
            Console.WriteLine("write no of copies needed to be restocked");
            int restockcopies = int.Parse(Console.ReadLine());
            Console.WriteLine("SHOW DETAILS");

            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine(bookList[i].Title());
                Console.WriteLine(bookList[i].Author());
                Console.WriteLine(bookList[i].PublicationYear());
                Console.WriteLine(bookList[i].Price());
                Console.WriteLine(bookList[i].QuanttyinStock());
            }
            Console.WriteLine(Restockcopies(bookList, ref bookcount, restockcopies, titleOfbook));
            Console.ReadKey();
        }
        static book addbook(List<book> bookList, ref int bookcount)
        {
       
            Console.WriteLine("WRITE title : ");
            bookList[bookcount].title = Console.ReadLine();
            Console.WriteLine("WRITE author");
            bookList[bookcount].author = (Console.ReadLine());
            Console.WriteLine("WRITE publicationYear");
            bookList[bookcount].publicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("WRITE price:");
            bookList[bookcount].price = double.Parse(Console.ReadLine());
             Console.WriteLine("WRITE quantity in stock:");
            bookList[bookcount].quantityinStock = int.Parse(Console.ReadLine());

                  bookcount++;
            return bookList[bookcount];
        }
        static string Sellcopies(List<book> bookList, ref int bookcount, int sellcopies, string titleOfbook)
        {
            for (int i = 0; i < bookcount; i++)
            {
                if (titleOfbook == bookList[i].title)
                {
                    int index = i;
                    if (bookList[index].quantityinStock >= sellcopies)
                    {
                        bookList[index].quantityinStock = bookList[index].quantityinStock - sellcopies;
                        return $"available and left books are {bookList[index].quantityinStock} ";

                    }
                }
            }
            return "error due to unavailability in stock ";
        }
        static string Restockcopies(List<book> bookList, ref int bookcount, int restockcopies, string titleOfbook)
        {
            for (int i = 0; i < bookcount; i++)
            {
                if (titleOfbook == bookList[i].title)
                {
                        bookList[i].quantityinStock = bookList[i].quantityinStock + restockcopies;
                        return $"available books are now {bookList[i].quantityinStock}";

                 
                }
               
            }
          
            return "can't restock the book as this book is not present ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{   
    internal class Book
    {
        private string Name;
        private Author A;
        private int Quantity;
        private float Price;
        private static List<Book>BookList=new List<Book>();
        public Book(string name,float price,int quantity,string authorName,string authorEmail,char gender)
        {
            Name = name;
            Price = price;
           Quantity = quantity;
            A = new Author(authorName,authorEmail,gender);
        }
        public string GetAllBooksNames()
        {

            return Name;
        }
        public static  string BookAdd(Book B)
        {
            BookList.Add(B);
            return "Book added";
        }
        public static  List<Book>  GetAllBookList()
        {
            return  BookList;
        }
        public Author  GetAuthor()
        {
            return A;
        }
    }
}
